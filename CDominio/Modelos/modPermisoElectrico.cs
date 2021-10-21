using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using CAccesoDatos.Repositorios;
using CDominio.ObjetosDeValor;
using CComun.Cache;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using System.Diagnostics;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Layout.Borders;

namespace CDominio.Modelos
{
    public class modPermisoElectrico
    {
        #region Campos
        private int _NumPermiso;
        private byte _Acronimo;
        private DateTime _Fecha;
        private int _Expediente;
        private int _TipoConex;
        private int _TipoMedid;
        private int _TipoObraConex;
        private decimal _PotenciaHP;
        private string _Dias;
        private string _Iniciador;
        private string _Domicilio;
        private int _Localidad;
        private int _Inspector;
        private string _Observaciones;
        private string _Comprobante;
        private decimal _Importe;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioPermisoElectrico repositorioPE;
        #endregion

        #region Propiedades
        public EstadoEntidad estado { private get; set; }
        public int NumPermiso { get => _NumPermiso; set => _NumPermiso = value; }
        public byte Acronimo { get => _Acronimo; set => _Acronimo = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int Expediente { get => _Expediente; set => _Expediente = value; }
        public int TipoConex { get => _TipoConex; set => _TipoConex = value; }
        public int TipoMedid { get => _TipoMedid; set => _TipoMedid = value; }
        public int TipoObraConex { get => _TipoObraConex; set => _TipoObraConex = value; }
        public decimal PotenciaHP
        {
            get => _PotenciaHP; 
            set
            {
                if (value > 0)
                    _PotenciaHP = value;
                else
                    throw new Exception("La potencia debe ser un valor mayor a 0.");
            }
        }
        public string Dias { get => _Dias; set => _Dias = value; }
        public string Iniciador
        {
            get => _Iniciador; 
            set
            {
                if (value.Length > 0)
                    _Iniciador = value;
                else
                    throw new Exception("Se debe colocar un iniciador del tramite.");
            }
        }
        public string Domicilio
        {
            get => _Domicilio; 
            set
            {
                if (value.Length > 0)
                    _Domicilio = value;
                else
                    throw new Exception("Se debe colocar el domicilio de la conexion electrica.");
            }
        }
        public int Localidad { get => _Localidad; set => _Localidad = value; }
        public int Inspector { get => _Inspector; set => _Inspector = value; }
        public string Observaciones
        {
            get => _Observaciones; 
            set
            {
                if (value.Length > 0)
                    _Observaciones = value;
                else
                    _Observaciones = "NINGUNA";
            }
        }
        public string Comprobante { get => _Comprobante; set => _Comprobante = value; }
        public decimal Importe { get => _Importe; set => _Importe = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        #region Metodos
        public modPermisoElectrico()
        {
            repositorioPE = new repPermisoElectrico();
        }

        public string GuardarCambios()
        {
            string mensaje = "";

            try
            {
                var permisoCE = new entPermisoElectrico();
                permisoCE.NumPermiso = NumPermiso;
                permisoCE.Acronimo = Acronimo;
                permisoCE.Fecha = Fecha;
                permisoCE.Expediente = Expediente;
                permisoCE.TipoConex = TipoConex;
                permisoCE.TipoMedid = TipoMedid;
                permisoCE.TipoObraConex = TipoObraConex;
                permisoCE.PotenciaHP = PotenciaHP;
                permisoCE.Dias = Dias;
                permisoCE.Iniciador = Iniciador;
                permisoCE.Domicilio = Domicilio;
                permisoCE.Localidad = Localidad;
                permisoCE.Inspector = Inspector;
                permisoCE.Observaciones = Observaciones;
                permisoCE.Comprobante = Comprobante;
                permisoCE.Importe = Importe;
                permisoCE.UsuarioCrea = UsuarioCrea;
                permisoCE.FechaCrea = FechaCrea;
                permisoCE.UsuarioModif = UsuarioModif;
                permisoCE.FechaUltModif = FechaUltModif;

                switch (estado)
                {
                    case EstadoEntidad.Agregar:
                        //De ser necesario, agregar antes los metodos para realizar comprobaciones o calculos
                        var numPermiso = repositorioPE.Agregar(permisoCE);
                        if (numPermiso > 0)
                        {
                            mensaje = "Se genero correctamente el permiso n° " + numPermiso;
                            GenerarPdfPermiso(numPermiso);
                        }
                        else
                            mensaje = "No se pudo generar el permiso";
                        break;

                    case EstadoEntidad.Modificar:
                        throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;                
            }

            return mensaje;
        }

        public List<modPermisoElectrico> ObtenerPermisos()
        {
            var enumPermisos = repositorioPE.ObtenerRegistros();
            var listaPermisos = new List<modPermisoElectrico>();
            foreach (entPermisoElectrico permiso in enumPermisos)
            {
                listaPermisos.Add(new modPermisoElectrico { 
                    NumPermiso = permiso.NumPermiso,
                    Acronimo = permiso.Acronimo,
                    Fecha = permiso.Fecha,
                    Expediente = permiso.Expediente,
                    TipoConex = permiso.TipoConex,
                    TipoMedid = permiso.TipoMedid,
                    TipoObraConex = permiso.TipoObraConex,
                    PotenciaHP = permiso.PotenciaHP,
                    Dias = permiso.Dias,
                    Iniciador = permiso.Iniciador,
                    Domicilio = permiso.Domicilio,
                    Localidad = permiso.Localidad,
                    Inspector = permiso.Inspector,
                    Observaciones = permiso.Observaciones,
                    Comprobante = permiso.Comprobante,
                    Importe = permiso.Importe,
                    UsuarioCrea = permiso.UsuarioCrea,
                    FechaCrea = permiso.FechaCrea,
                    UsuarioModif = permiso.UsuarioModif,
                    FechaUltModif = permiso.FechaUltModif
                });
            }
            return listaPermisos;
        }

        private string GenerarCadenaAleatoria()
        {
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var arregloCaracteres = new Char[5];
            var random = new Random();
            for (int i = 0; i < arregloCaracteres.Length; i++)
            {
                arregloCaracteres[i] = caracteres[random.Next(caracteres.Length)];
            }
            var aleatorio = new String(arregloCaracteres);
            return aleatorio;
        }

        public void GenerarPdfPermiso(int numPermiso)
        {
            //Datos para el pdf
            var tablaDatos = repositorioPE.DatosPermisosPDF(numPermiso);
            var acronimo = tablaDatos.Rows[0].ItemArray[1].ToString();
            var fecPer = Convert.ToDateTime(tablaDatos.Rows[0].ItemArray[2]);
            var fechaPermiso = String.Format(fecPer.ToShortDateString(), "dd/mm/aaaa");
            var expediente = tablaDatos.Rows[0].ItemArray[3].ToString() + "-" + tablaDatos.Rows[0].ItemArray[4].ToString() + "-" + tablaDatos.Rows[0].ItemArray[5].ToString();
            var tipoConex = tablaDatos.Rows[0].ItemArray[6].ToString();
            var tipoMedidor = tablaDatos.Rows[0].ItemArray[7].ToString();
            var tipoObraDec = tablaDatos.Rows[0].ItemArray[8].ToString();
            //Potencia en HP y Vatios 1HP = 745.7W
            var potHP = Convert.ToDecimal(tablaDatos.Rows[0].ItemArray[9]);
            var potVat = Math.Round(Convert.ToDecimal(potHP * 745.7M), 2);
            var dias = tablaDatos.Rows[0].ItemArray[10].ToString();
            var iniciador = tablaDatos.Rows[0].ItemArray[11].ToString();
            var domicilio = tablaDatos.Rows[0].ItemArray[12].ToString();
            var localidad = tablaDatos.Rows[0].ItemArray[13].ToString();
            //Comprobar si el inspector posee un titulo o ninguno
            var inspector = "";
            if(tablaDatos.Rows[0].ItemArray[16].ToString() == "NINGUNO")
                inspector = tablaDatos.Rows[0].ItemArray[15].ToString() + " " + tablaDatos.Rows[0].ItemArray[14].ToString();
            else
                inspector = tablaDatos.Rows[0].ItemArray[16].ToString() + " " + tablaDatos.Rows[0].ItemArray[15].ToString() + " " + tablaDatos.Rows[0].ItemArray[14].ToString();
            var entregadoPor = cacUsuario.Nombre + " " + cacUsuario.Apellido;
            var observaciones = tablaDatos.Rows[0].ItemArray[17].ToString();

            //Otengo la ruta directa a mis Documentos para crear ahi los pdf
            string rutaDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Gestion Aforos\\Permisos Conexion Electrica";
            var randomStamp = GenerarCadenaAleatoria();
            string rutaCompleta = rutaDir + "\\permiso_num_" + numPermiso + "_" + randomStamp + ".pdf";
            //Compruebo si existe la carpeta donde se guardan los pdf, si no existe se crea, pero si existe no se crea
            Directory.CreateDirectory(rutaDir);
            
            PdfWriter pdfW = new PdfWriter(rutaCompleta);
            PdfDocument pdfDoc = new PdfDocument(pdfW);
            Document document = new Document(pdfDoc);

            //Encabezado
            Paragraph espacioBlanco = new Paragraph("\n");
            Image logo = new Image(ImageDataFactory
                .Create(AppDomain.CurrentDomain.BaseDirectory + @"\imagenes\logo_muni.png"))
                .SetTextAlignment(TextAlignment.LEFT);
            Paragraph headNumPer = new Paragraph("PERMISO DE CONEXION Nº " + acronimo + "-" + numPermiso + "\n" + "GENERAL ALVEAR, MENDOZA - " + fechaPermiso)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBold()
                .SetFontSize(12);
            
            Table tablaEncabezado = new Table(2, true);            
            Cell celdaEncab11 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.WHITE)
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.LEFT)                
                .SetWidth(35f)
                .Add(logo);
            Cell celdaEncab12 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.WHITE)
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                .Add(headNumPer);

            tablaEncabezado.AddCell(celdaEncab11);
            tablaEncabezado.AddCell(celdaEncab12);
            document.Add(tablaEncabezado);
            document.Add(espacioBlanco);

            //Cuerpo
            var texto = "ESTIMADA COOPERATIVA DE ELECTRICIDAD, POR MEDIO DEL PRESENTE PERMISO SE PROCEDE A INFORMAR QUE, SEGUN LA RESOLUCION EMANADA DEL EXPEDIENTE " + expediente + " Y HABIENDO CUMPLIDO LOS REQUISITOS DE LA ORDENANZA DE INSTALACIONES ELECTICAS, SE LE CONCEDE UN PERMISO DE CONEXION ELECTRICA CON LAS SIGUIENTES CARACTERISTICAS:";
            Paragraph textoCuerpo = new Paragraph(texto)
                .SetTextAlignment(TextAlignment.JUSTIFIED)
                .SetBold()
                .SetFontSize(12);
            Table tablaCuerpo = new Table(2, false);
            Cell celdaCuerpo11 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("TIPO CONEXION"));
            Cell celdaCuerpo12 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(tipoConex));
            Cell celdaCuerpo21 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("TIPO MEDIDOR"));
            Cell celdaCuerpo22 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(tipoMedidor));
            Cell celdaCuerpo31 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("ASUNTO CONEXION"));
            Cell celdaCuerpo32 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(tipoObraDec));
            Cell celdaCuerpo41 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("POTENCIA"));
            Cell celdaCuerpo42 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(potHP + " HP - " + potVat + " Watts"));
            Cell celdaCuerpo51 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("DIAS"));
            Cell celdaCuerpo52 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(dias));
            Cell celdaCuerpo61 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("INICIADOR"));
            Cell celdaCuerpo62 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(iniciador));
            Cell celdaCuerpo71 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("DOMICILIO CONEXION"));
            Cell celdaCuerpo72 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(domicilio));
            Cell celdaCuerpo81 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("LOCALIDAD"));
            Cell celdaCuerpo82 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(localidad));
            Cell celdaCuerpo91 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("INSPECTOR"));
            Cell celdaCuerpo92 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(inspector));
            Cell celdaCuerpo101 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("ENTREGADO POR"));
            Cell celdaCuerpo102 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(entregadoPor));
            Cell celdaCuerpo111 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph("OBSERVACIONES"));
            Cell celdaCuerpo112 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.LEFT)
                .Add(new Paragraph(observaciones));

            tablaCuerpo.AddCell(celdaCuerpo11);
            tablaCuerpo.AddCell(celdaCuerpo12);
            tablaCuerpo.AddCell(celdaCuerpo21);
            tablaCuerpo.AddCell(celdaCuerpo22);
            tablaCuerpo.AddCell(celdaCuerpo31);
            tablaCuerpo.AddCell(celdaCuerpo32);
            tablaCuerpo.AddCell(celdaCuerpo41);
            tablaCuerpo.AddCell(celdaCuerpo42);
            tablaCuerpo.AddCell(celdaCuerpo51);
            tablaCuerpo.AddCell(celdaCuerpo52);
            tablaCuerpo.AddCell(celdaCuerpo61);
            tablaCuerpo.AddCell(celdaCuerpo62);
            tablaCuerpo.AddCell(celdaCuerpo71);
            tablaCuerpo.AddCell(celdaCuerpo72);
            tablaCuerpo.AddCell(celdaCuerpo81);
            tablaCuerpo.AddCell(celdaCuerpo82);
            tablaCuerpo.AddCell(celdaCuerpo91);
            tablaCuerpo.AddCell(celdaCuerpo92);
            tablaCuerpo.AddCell(celdaCuerpo101);
            tablaCuerpo.AddCell(celdaCuerpo102);
            tablaCuerpo.AddCell(celdaCuerpo111);
            tablaCuerpo.AddCell(celdaCuerpo112);
                        
            document.Add(textoCuerpo);
            document.Add(espacioBlanco);
            document.Add(tablaCuerpo.SetHorizontalAlignment(HorizontalAlignment.CENTER));

            //Final Cuerpo            
            Paragraph sello = new Paragraph("__________________________" + "\n" + "FIRMA Y SELLO")
                .SetTextAlignment(TextAlignment.CENTER);

            document.Add(espacioBlanco);
            document.Add(espacioBlanco);
            document.Add(espacioBlanco);
            document.Add(sello);
            document.Close();

            //Al finalizar, abro el pdf en la ruta donde se guardo
            Process.Start(rutaCompleta);
        }
        #endregion
    }
}
