using ClosedXML.Excel;
using Ivi.Visa.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace SG_SA_Sequence
{
    public partial class Form1 : Form
    {
        // VISA COM objects
        private Ivi.Visa.Interop.ResourceManager rm;
        private FormattedIO488 sgSession;
        private FormattedIO488 saSession;

        // Frequency & Power storage
        private List<(double freq, double power)> freqPowerList = new List<(double, double)>();

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        // Initialize UI state
        private void InitializeUI()
        {
            // Disable all except Close button
            button_Close.Enabled = true;
            button_SG_connection.Enabled = true;
            button_SA_connection.Enabled = true;

            button_Freq1_Set.Enabled = false;
            button_Freq2_Set.Enabled = false;
            button_Freq3_Set.Enabled = false;
            button_Freq4_Set.Enabled = false;
            button_Freq5_Set.Enabled = false;

            button_Measurement.Enabled = false;
            button_Reset.Enabled = false;
            button_Save.Enabled = false;

            textFreq1.Enabled = false;
            textFreq2.Enabled = false;
            textFreq3.Enabled = false;
            textFreq4.Enabled = false;
            textFreq5.Enabled = false;

            textPower1.Enabled = false;
            textPower2.Enabled = false;
            textPower3.Enabled = false;
            textPower4.Enabled = false;
            textPower5.Enabled = false;

            textBox_save_location.Enabled = false;
        }

        // SG Connection
        private void button_SG_connection_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sgAddress = textBox_SG_address.Text.Trim();
                rm = new Ivi.Visa.Interop.ResourceManager();
                sgSession = new FormattedIO488();
                sgSession.IO = (IMessage)rm.Open(sgAddress); // Example: GPIB0::5::INSTR
                sgSession.WriteString("*IDN?");
                string idn = sgSession.ReadString();
                MessageBox.Show("SG Connected: " + idn);
                // SG Preset
                sgSession.WriteString("*RST");
                sgSession.WriteString("OUTP OFF");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SG Connection Failed: " + ex.Message);
            }
        }

        // SA Connection
        private void button_SA_connection_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = textBox_SA_address.Text.Trim(); // User enters only "192.168.32.10"
                string visaAddress = $"TCPIP0::{ipAddress}::hislip0::INSTR"; // Auto-build VISA address
                rm = new Ivi.Visa.Interop.ResourceManager();
                saSession = new FormattedIO488();
                saSession.IO = (IMessage)rm.Open(visaAddress);
                saSession.WriteString("*IDN?");
                string idn = saSession.ReadString();
                MessageBox.Show("SA Connected: " + idn);
                // SA Preset
                saSession.WriteString("*RST");
                button_Freq1_Set.Enabled = true;
                textFreq1.Enabled = true;
                textPower1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SA Connection Failed: " + ex.Message);
            }
        }

        // Validate frequency and power
        private bool ValidateInput(double freq, double power)
        {
            if (freq < 0.25 || freq > 3000) return false;
            if (power < -136 || power > 20) return false;
            return true;
        }

        // Freq1 Set
        private void button_Freq1_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq1.Text);
            double power = double.Parse(textPower1.Text);

            if (!ValidateInput(freq, power))
            {
                MessageBox.Show("Out of Range");
                return;
            }

            freqPowerList.Add((freq, power));
            MessageBox.Show("Freq1 & Power Setup Completed");

            // Disable current controls
            textFreq1.Enabled = false;
            textPower1.Enabled = false;
            button_Freq1_Set.Enabled = false;

            // Enable next controls
            textFreq2.Enabled = true;
            textPower2.Enabled = true;
            button_Freq2_Set.Enabled = true;

            button_Reset.Enabled = true;
            button_Measurement.Enabled = true;
        }

        // Freq2 Set
        private void button_Freq2_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq2.Text);
            double power = double.Parse(textPower2.Text);

            if (!ValidateInput(freq, power))
            {
                MessageBox.Show("Out of Range");
                return;
            }

            freqPowerList.Add((freq, power));
            MessageBox.Show("Freq2 & Power Setup Completed");

            // Disable current
            textFreq2.Enabled = false;
            textPower2.Enabled = false;
            button_Freq2_Set.Enabled = false;

            // Enable next
            textFreq3.Enabled = true;
            textPower3.Enabled = true;
            button_Freq3_Set.Enabled = true;
        }

        // Freq3 Set
        private void button_Freq3_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq3.Text);
            double power = double.Parse(textPower3.Text);

            if (!ValidateInput(freq, power))
            {
                MessageBox.Show("Out of Range");
                return;
            }

            freqPowerList.Add((freq, power));
            MessageBox.Show("Freq3 & Power Setup Completed");

            // Disable current controls
            textFreq3.Enabled = false;
            textPower3.Enabled = false;
            button_Freq3_Set.Enabled = false;

            // Enable next controls
            textFreq4.Enabled = true;
            textPower4.Enabled = true;
            button_Freq4_Set.Enabled = true;
        }

        // Freq4 Set
        private void button_Freq4_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq4.Text);
            double power = double.Parse(textPower4.Text);

            if (!ValidateInput(freq, power))
            {
                MessageBox.Show("Out of Range");
                return;
            }

            freqPowerList.Add((freq, power));
            MessageBox.Show("Freq4 & Power Setup Completed");

            // Disable current controls
            textFreq4.Enabled = false;
            textPower4.Enabled = false;
            button_Freq4_Set.Enabled = false;

            // Enable next controls
            textFreq5.Enabled = true;
            textPower5.Enabled = true;
            button_Freq5_Set.Enabled = true;
        }

        // Freq5 Set
        private void button_Freq5_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq5.Text);
            double power = double.Parse(textPower5.Text);

            if (!ValidateInput(freq, power))
            {
                MessageBox.Show("Out of Range");
                return;
            }

            freqPowerList.Add((freq, power));
            MessageBox.Show("Freq5 & Power Setup Completed");

            // Disable current controls
            textFreq5.Enabled = false;
            textPower5.Enabled = false;
            button_Freq5_Set.Enabled = false;
        }

        // Offset Calculation by Linear
        private double CalculateOffset(double freq)
        {
            // Reference points:
            // 0 GHz = -0.5 dB
            // 1 GHz = -0.91 dB
            // 2 GHz = -1.13 dB
            // 3 GHz = -1.42 dB
            if (freq <= 0) return 0.5;
            if (freq <= 1000)
            {
                return -0.5 + (freq / 1000.0) * (-0.91 + 0.5);
            }
            else if (freq <= 2000)
            {
                return -0.91 + ((freq - 1000.0) / 1000.0) * (-1.13 + 0.91);
            }
            else if (freq <= 3000)
            {
                return -1.13 + ((freq - 2000.0) / 1000.0) * (-1.42 + 1.13);
            }
            else
            {
                return -1.42;
            }
        }

        // Measurement Process
        private void button_Measurement_Click_1(object sender, EventArgs e)
        {
            try
            {
                // SG Preset
                sgSession.WriteString("*RST");

                // SA Preset
                saSession.WriteString("*RST");

                foreach (var item in freqPowerList)
                {
                    double freq = item.freq;
                    double power = item.power;
                    double offset = CalculateOffset(freq);

                    // Apply offset to SA (invert sign for compensation)
                    double saOffset = -offset; // flip sign

                    // Set VISA timeout
                    sgSession.IO.Timeout = 15000;
                    saSession.IO.Timeout = 15000;

                    // SG setup
                    sgSession.WriteString($"FREQ:CW {freq}MHz");
                    sgSession.WriteString($"POW {power}dBm");
                    sgSession.WriteString("OUTP OFF");

                    // SA setup
                    saSession.WriteString($"FREQ:CENT {freq}MHz");
                    saSession.WriteString("SENSE:FREQ:SPAN 300MHz");
                    saSession.WriteString("DISP:WIND:TRAC:Y:RLEV 20dBm");
                    saSession.WriteString("SENSE:BAND:RES 100kHz");
                    saSession.WriteString("SENSE:POW:RF:ATT 30");
                    saSession.WriteString($"DISP:WIND:TRAC:Y:RLEV:OFFS {saOffset}");


                    // Perform sweep for Noise Floor
                    saSession.WriteString(":INIT:IMM");
                    saSession.WriteString("*OPC?");
                    saSession.ReadString();
                    saSession.WriteString(":TRAC:DATA? TRACE1");
                    string traceData = saSession.ReadString();

                    // Parse and calculate top 30 point's average for Noise Floor
                    double[] points = traceData.Split(',').Select(double.Parse).ToArray();
                    double[] top30 = points.OrderByDescending(x => x).Take(30).ToArray();
                    double noiseFloor = Math.Round(top30.Average(), 3, MidpointRounding.AwayFromZero);


                    // SG setup
                    sgSession.WriteString("OUTP ON");
                    System.Threading.Thread.Sleep(2000);

                    // Trigger sweep and wait
                    saSession.WriteString(":INIT:IMM");
                    saSession.WriteString("*OPC?");
                    string opc = saSession.ReadString();
                    System.Threading.Thread.Sleep(2000);

                    // Marker setup
                    saSession.WriteString("CALC:MARK1:STATE ON");
                    saSession.WriteString("CALC:MARK1:MODE POS");
                    saSession.WriteString($":CALC:MARK1:X {freq}E6"); // freq in MHz → Hz

                    // Read marker value
                    saSession.WriteString("CALC:MARK1:Y?");
                    double measuredPower = Math.Round(double.Parse(saSession.ReadString()), 2, MidpointRounding.AwayFromZero);
                    System.Threading.Thread.Sleep(2000);

                    sgSession.WriteString("OUTP OFF");

                    // Add row to DataGridView
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = freq;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = measuredPower.ToString("F2");
                    dataGridView1.Rows[rowIndex].Cells[8].Value = offset;
                    dataGridView1.Rows[rowIndex].Cells[9].Value = noiseFloor.ToString("F3");

                    // Harmonics (2x, 3x, 4x)
                    for (int i = 2; i <= 4; i++)
                    {
                        double harmonicFreq = freq * i;
                        if (harmonicFreq > 8400) continue;

                        // SG setup
                        sgSession.WriteString($"FREQ:CW {freq}MHz");
                        sgSession.WriteString("OUTP ON");
                        System.Threading.Thread.Sleep(2000);

                        // SA setup
                        saSession.WriteString($"FREQ:CENT {harmonicFreq}MHz");

                        // Trigger sweep and wait
                        saSession.WriteString(":INIT:IMM");
                        saSession.WriteString("*OPC?");
                        opc = saSession.ReadString();
                        System.Threading.Thread.Sleep(2000);

                        // Marker setup
                        saSession.WriteString("CALC:MARK1:STATE ON");
                        saSession.WriteString("CALC:MARK1:MODE POS");
                        saSession.WriteString($":CALC:MARK1:X {harmonicFreq}E6"); // freq in MHz → Hz

                        // Read marker value
                        saSession.WriteString("CALC:MARK1:Y?");
                        double harmonicPower = Math.Round(double.Parse(saSession.ReadString()), 2, MidpointRounding.AwayFromZero);
                        System.Threading.Thread.Sleep(2000);

                        sgSession.WriteString("OUTP OFF");

                        dataGridView1.Rows[rowIndex].Cells[(i - 1) * 2].Value = harmonicFreq;
                        dataGridView1.Rows[rowIndex].Cells[(i - 1) * 2 + 1].Value = harmonicPower.ToString("F2");
                    }
                }

                MessageBox.Show("Measurement Completed");
                textBox_save_location.Enabled = true;
                button_Save.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Measurement Failed: " + ex.Message);
            }
        }

        // Save Data to Excel
        private void button_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = textBox_save_location.Text.Trim();
                if (!Directory.Exists(path))
                {
                    MessageBox.Show("Invalid Path");
                    return;
                }

                string filePath = Path.Combine(path, "Harmonic_test_Result.xlsx");

                // Prior file remove
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Result");

                // Write headers
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    var headerCell = ws.Cell(1, i + 1);
                    headerCell.Value = dataGridView1.Columns[i].HeaderText;

                    // 1st raw : bold font
                    headerCell.Style.Font.Bold = true;
                    // 1st raw : cell color light gray
                    headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                }

                // Write data
                for (int r = 0; r < dataGridView1.Rows.Count; r++)
                {
                    if (dataGridView1.Rows[r].IsNewRow) continue;
                    for (int c = 0; c < dataGridView1.Columns.Count; c++)
                    {
                        var cellValue = dataGridView1.Rows[r].Cells[c].Value?.ToString() ?? "";

                        // Measured Power[dBm] (Column 1) → 소수점 3자리
                        if (c == 1 && double.TryParse(cellValue, out double power))
                        {
                            ws.Cell(r + 2, c + 1).Value = power.ToString("F2");
                        }
                        // Noise Floor[dBm] (Column 9) → 소수점 4자리
                        else if (c == 9 && double.TryParse(cellValue, out double noise))
                        {
                            ws.Cell(r + 2, c + 1).Value = noise.ToString("F3");
                        }
                        else
                        {
                            ws.Cell(r + 2, c + 1).Value = cellValue;
                        }
                    }
                }

                // Auto adjust for column width
                ws.Columns().AdjustToContents();

                // Make border for data cell only
                var range = ws.Range(1, 1, dataGridView1.Rows.Count, dataGridView1.Columns.Count);
                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.OutsideBorderColor = XLColor.Black;
                range.Style.Border.InsideBorderColor = XLColor.Black;

                wb.SaveAs(filePath);
                MessageBox.Show("Excel Save Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel Save Failed: " + ex.Message);
            }

        }

        // Reset
        private void button_Reset_Click_1(object sender, EventArgs e)
        {
            freqPowerList.Clear();
            dataGridView1.Rows.Clear();
            textFreq1.Clear();
            textFreq2.Clear();
            textFreq3.Clear();
            textFreq4.Clear();
            textFreq5.Clear();
            textPower1.Clear();
            textPower2.Clear();
            textPower3.Clear();
            textPower4.Clear();
            textPower5.Clear();

            button_Close.Enabled = true;
            button_SG_connection.Enabled = true;
            button_SA_connection.Enabled = true;

            button_Freq1_Set.Enabled = true;
            button_Freq2_Set.Enabled = false;
            button_Freq3_Set.Enabled = false;
            button_Freq4_Set.Enabled = false;
            button_Freq5_Set.Enabled = false;

            button_Measurement.Enabled = false;
            button_Reset.Enabled = false;
            button_Save.Enabled = false;

            textFreq1.Enabled = true;
            textFreq2.Enabled = false;
            textFreq3.Enabled = false;
            textFreq4.Enabled = false;
            textFreq5.Enabled = false;

            textPower1.Enabled = true;
            textPower2.Enabled = false;
            textPower3.Enabled = false;
            textPower4.Enabled = false;
            textPower5.Enabled = false;

            textBox_save_location.Enabled = false;
        }

        // Close
        private void button_Close_Click_1(object sender, EventArgs e)
        {
            try
            {
                sgSession?.WriteString("*RST");
                saSession?.WriteString("*RST");
            }
            catch { }
            Application.Exit();
        }
    }
}
