using PCSC;
using PCSC.Iso7816;
using PCSC.Utils;
using System;
using System.Windows.Forms;

namespace LectorPCSC_WF
{
    public partial class Form1 : Form
    {
        private SCardContext _context;
        private string _selectedReader;
        public Form1()
        {
            InitializeComponent();
            LoadReaders();
            BtnReadAtr.Enabled = false;
            BtnReadUID.Enabled = false;
            var versiones = typeof(Form1).Assembly.GetName().Version;
            lblVersion.Text = $"Versión {versiones}";
        }
        private void LoadReaders()
        {
            _context = new SCardContext();
            _context.Establish(SCardScope.System);

            var readerNames = _context.GetReaders();
            if (readerNames == null || readerNames.Length == 0)
            {
                MessageBox.Show("No se encontraron lectores.");
                return;
            }

            comboBoxReaders.Items.AddRange(readerNames);
        }

        private void BtnReadAtr_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = _context.ConnectReader(_selectedReader, SCardShareMode.Shared, SCardProtocol.Any))
                {
                    //reader.Connect(_selectedReader, SCardShareMode.Shared, SCardProtocol.Any);
                    //var status = reader.GetStatus();
                    var atr = reader.GetAttrib(SCardAttribute.AtrString);
                    textBoxOutput.Text = "ATR: " + BitConverter.ToString(atr).Replace("-","");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer ATR: {ex.Message}");
            }
        }

        private void ComboBoxReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedReader = comboBoxReaders.SelectedItem.ToString();
            BtnReadAtr.Enabled = true;
            BtnReadUID.Enabled = true;
        }

        private void BtnReadUID_Click(object sender, EventArgs e)
        {
            try
            {
                var readerName = _selectedReader.ToLower();
                if (!readerName.Contains("cl"))
                {
                    MessageBox.Show("El lector seleccionado no es compatible con tarjetas sin contacto.");
                    return;
                }
                using (var reader = new IsoReader(_context, _selectedReader, SCardShareMode.Shared, SCardProtocol.Any, false))
                {
                    // Crear el comando APDU para obtener el UID de la tarjeta MIFARE
                    var apdu = new CommandApdu(IsoCase.Case2Short, reader.ActiveProtocol)
                    {
                        CLA = 0xFF, // Clase de la instrucción
                        INS = 0xCA, // Instrucción para obtener el UID
                        P1 = 0x00,  // Parámetro 1
                        P2 = 0x00,  // Parámetro 2
                        Le = 0x00   // Longitud esperada de la respuesta
                    };

                    var response = reader.Transmit(apdu);
                    var cardId = BitConverter.ToString(response.GetData());
                    textBoxOutput.Text = "UID de la tarjeta: " + cardId.Replace("-", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer UID: {ex.Message}");
            }
        }
    }
}
