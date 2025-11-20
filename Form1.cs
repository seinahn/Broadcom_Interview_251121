using ClosedXML.Excel;　　　　　　　　　　　// Import ClosedXML for Excel file operations
using Ivi.Visa.Interop;                  // Import VISA COM library for instrument communication
using System;                            // Import base system functionalities
using System.Collections.Generic;        // Import generic collections like List
using System.Data;                       // Import data handling classes
using System.IO;                         // Import file I/O operations
using System.Linq;                       // Import LINQ for data queries
using System.Windows.Forms;              // Import Windows Forms for UI components

namespace SG_SA_Sequence
{
    public partial class Form1 : Form
    {
        // VISA COM objects for instrument communication
        private Ivi.Visa.Interop.ResourceManager rm;                                                    // Resource manager for VISA sessions
        private FormattedIO488 sgSession;                                                               // Session for Signal Generator (SG)
        private FormattedIO488 saSession;                                                               // Session for Spectrum Analyzer (SA)

        // List to store frequency and power pairs
        private List<(double freq, double power)> freqPowerList = new List<(double, double)>();         // Tuple list for measurement data

        public Form1()
        {
            InitializeComponent();                                                                      // Initialize UI components
            InitializeUI();                                                                             // Set initial UI state
        }

        // Method to initialize UI state
        private void InitializeUI()
        {
            // Disable all except Close button
            button_Close.Enabled = true;                                                                // Enable Close button
            button_SG_connection.Enabled = true;                                                        // Enable SG connection button
            button_SA_connection.Enabled = true;                                                        // Enable SA connection button

            button_Freq1_Set.Enabled = false;                                                           // Disable frequency setting buttons
            button_Freq2_Set.Enabled = false;
            button_Freq3_Set.Enabled = false;
            button_Freq4_Set.Enabled = false;
            button_Freq5_Set.Enabled = false;

            button_Measurement.Enabled = false;                                                         // Disable measurement and save buttons
            button_Reset.Enabled = false;
            button_Save.Enabled = false;

            textFreq1.Enabled = false;                                                                  // Disable frequency input text boxes
            textFreq2.Enabled = false;
            textFreq3.Enabled = false;
            textFreq4.Enabled = false;
            textFreq5.Enabled = false;

            textPower1.Enabled = false;                                                                 // Disable power input text boxes
            textPower2.Enabled = false;
            textPower3.Enabled = false;
            textPower4.Enabled = false;
            textPower5.Enabled = false;

            textBox_save_location.Enabled = false;                                                      // Disable save location input
        }

        // SG connection
        private void button_SG_connection_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sgAddress = textBox_SG_address.Text.Trim();                                      // Get SG VISA address from input

                rm = new Ivi.Visa.Interop.ResourceManager();                                            // Create VISA resource manager
                sgSession = new FormattedIO488();                                                       // Create SG session
                sgSession.IO = (IMessage)rm.Open(sgAddress);                                            // Open SG connection (e.g., GPIB0::5::INSTR)
                sgSession.WriteString("*IDN?");                                                         // Query instrument identification
                string idn = sgSession.ReadString();                                                    // Read response
                MessageBox.Show("SG Connected: " + idn);                                                // Show connection message
                sgSession.WriteString("*RST");                                                          // Reset SG to default state
                sgSession.WriteString("OUTP OFF");                                                      // Turn SG output off
            }
            catch (Exception ex)
            {
                MessageBox.Show("SG Connection Failed: " + ex.Message);                                 // Show error message
            }
        }

        // SA connection
        private void button_SA_connection_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = textBox_SA_address.Text.Trim();                                      // Get IP address from input
                string visaAddress = $"TCPIP0::{ipAddress}::hislip0::INSTR";                            // Build VISA address for SA

                rm = new Ivi.Visa.Interop.ResourceManager();                                            // Create VISA resource manager
                saSession = new FormattedIO488();                                                       // Create SA session
                saSession.IO = (IMessage)rm.Open(visaAddress);                                          // Open SA connection
                saSession.WriteString("*IDN?");                                                         // Query instrument identification
                string idn = saSession.ReadString();                                                    // Read response
                MessageBox.Show("SA Connected: " + idn);                                                // Show connection message
                saSession.WriteString("*RST");                                                          // Reset SA to default state

                button_Freq1_Set.Enabled = true;                                                        // Enable first frequency setting button
                textFreq1.Enabled = true;                                                               // Enable first frequency input
                textPower1.Enabled = true;                                                              // Enable first power input

            }
            catch (Exception ex)
            {
                MessageBox.Show("SA Connection Failed: " + ex.Message);                                 // Show error message
            }
        }

        // Validate frequency and power
        private bool ValidateInput(double freq, double power)
        {
            if (freq < 0.25 || freq > 3000) return false;                                               // Check if frequency is within 0.25 to 3000 MHz
            if (power < -136 || power > 20) return false;                                               // Check if power is within -136 to 20 dBm
            return true;                                                                                // Return true if both values are valid
        }

        // Freq1 Set
        private void button_Freq1_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq1.Text);                                                 // Parse frequency from input
            double power = double.Parse(textPower1.Text);                                               // Parse power from input

            if (!ValidateInput(freq, power))                                                            // Validate input range
            {
                MessageBox.Show("Out of Range");                                                        // Show error if invalid
                return;                                                                                 // Exit method
            }

            freqPowerList.Add((freq, power));                                                           // Add frequency and power tuple to list
            MessageBox.Show("Freq1 & Power Setup Completed");                                           // Notify user

            textFreq1.Enabled = false;                                                                  // Disable current controls
            textPower1.Enabled = false;
            button_Freq1_Set.Enabled = false;

            textFreq2.Enabled = true;                                                                   // Enable next controls
            textPower2.Enabled = true;
            button_Freq2_Set.Enabled = true;

            button_Reset.Enabled = true;                                                                // Enable reset button
            button_Measurement.Enabled = true;                                                          // Enable measurement button
        }

        // Freq2 Set
        private void button_Freq2_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq2.Text);                                                 // Parse frequency from input
            double power = double.Parse(textPower2.Text);                                               // Parse power from input

            if (!ValidateInput(freq, power))                                                            // Validate input range
            {
                MessageBox.Show("Out of Range");                                                        // Show error if invalid
                return;                                                                                 // Exit method
            }

            freqPowerList.Add((freq, power));                                                           // Add frequency and power tuple to list
            MessageBox.Show("Freq2 & Power Setup Completed");                                           // Notify user

            textFreq2.Enabled = false;                                                                  // Disable current controls
            textPower2.Enabled = false;
            button_Freq2_Set.Enabled = false;

            textFreq3.Enabled = true;                                                                   // Enable next controls
            textPower3.Enabled = true;
            button_Freq3_Set.Enabled = true;
        }

        // Freq3 Set
        private void button_Freq3_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq3.Text);                                                // Parse frequency from input
            double power = double.Parse(textPower3.Text);                                              // Parse power from input

            if (!ValidateInput(freq, power))                                                           // Validate input range
            {
                MessageBox.Show("Out of Range");                                                       // Show error if invalid
                return;                                                                                // Exit method
            }

            freqPowerList.Add((freq, power));                                                          // Add frequency and power tuple to list
            MessageBox.Show("Freq3 & Power Setup Completed");                                          // Notify user

            textFreq3.Enabled = false;                                                                 // Disable current controls
            textPower3.Enabled = false;
            button_Freq3_Set.Enabled = false;

            textFreq4.Enabled = true;                                                                  // Enable next controls
            textPower4.Enabled = true;
            button_Freq4_Set.Enabled = true;
        }

        // Freq4 Set
        private void button_Freq4_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq4.Text);                                                // Parse frequency from input
            double power = double.Parse(textPower4.Text);                                              // Parse power from input

            if (!ValidateInput(freq, power))                                                           // Validate input range
            {
                MessageBox.Show("Out of Range");                                                       // Show error if invalid
                return;// Exit method
            }

            freqPowerList.Add((freq, power));                                                          // Add frequency and power tuple to list
            MessageBox.Show("Freq4 & Power Setup Completed");                                          // Notify user

            textFreq4.Enabled = false;                                                                 // Disable current controls
            textPower4.Enabled = false;
            button_Freq4_Set.Enabled = false;

            textFreq5.Enabled = true;                                                                  // Enable next controls
            textPower5.Enabled = true;
            button_Freq5_Set.Enabled = true;
        }

        // Freq5 Set
        private void button_Freq5_Set_Click_1(object sender, EventArgs e)
        {
            double freq = double.Parse(textFreq5.Text);                                                // Parse frequency from input
            double power = double.Parse(textPower5.Text);                                              // Parse power from input

            if (!ValidateInput(freq, power))                                                           // Validate input range
            {
                MessageBox.Show("Out of Range");                                                       // Show error if invalid
                return;// Exit method
            }

            freqPowerList.Add((freq, power));                                                          // Add frequency and power tuple to list
            MessageBox.Show("Freq5 & Power Setup Completed");                                          // Notify user

            textFreq5.Enabled = false;                                                                 // Disable current controls
            textPower5.Enabled = false;
            button_Freq5_Set.Enabled = false;
        }

        // Offset Calculation by Linear
        private double CalculateOffset(double freq)
        {
            // Reference points for offset correction:
            // 0 GHz = -0.5 dB
            // 1 GHz = -0.91 dB
            // 2 GHz = -1.13 dB
            // 3 GHz = -1.42 dB

            if (freq <= 0) return -0.5;                                                                // If frequency is 0 or less, return +0.5 dB
            if (freq <= 1000)
            {
                return -0.5 + (freq / 1000.0) * (-0.91 + 0.5);                                         // Linear interpolation between 0 GHz and 1 GHz
            }
            else if (freq <= 2000)
            {
                return -0.91 + ((freq - 1000.0) / 1000.0) * (-1.13 + 0.91);                            // Linear interpolation between 1 GHz and 2 GHz
            }
            else if (freq <= 3000)
            {
                return -1.13 + ((freq - 2000.0) / 1000.0) * (-1.42 + 1.13);                            // Linear interpolation between 2 GHz and 3 GHz
            }
            else
            {
                return -1.42;                                                                          // Above 3 GHz, return -1.42 dB
            }
        }

        // Measurement Process
        private void button_Measurement_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Reset SG and SA to default state
                sgSession.WriteString("*RST");
                saSession.WriteString("*RST");

                foreach (var item in freqPowerList)                                                    // Loop through all frequency-power pairs
                {
                    double freq = item.freq;                                                           // Current frequency
                    double power = item.power;                                                         // Current power
                    double offset = CalculateOffset(freq);                                             // Calculate offset based on current frequenc
                    double saOffset = -offset;                                                         // Apply inverted offset for SA compensation

                    // Set VISA timeout for SG and SA
                    sgSession.IO.Timeout = 15000;
                    saSession.IO.Timeout = 15000;

                    // Configure SG
                    sgSession.WriteString($"FREQ:CW {freq}MHz");                                       // Set CW frequency
                    sgSession.WriteString($"POW {power}dBm");                                          // Set power level
                    sgSession.WriteString("OUTP OFF");                                                 // Keep SG output OFF initially

                    // Configure SA
                    saSession.WriteString($"FREQ:CENT {freq}MHz");                                     // Set center frequency
                    saSession.WriteString("SENSE:FREQ:SPAN 300MHz");                                   // Set span = 300 MHz
                    saSession.WriteString("DISP:WIND:TRAC:Y:RLEV 20dBm");                              // Reference level = 20 dBm
                    saSession.WriteString("SENSE:BAND:RES 100kHz");                                    // Resolution bandwidth = 100 kHz
                    saSession.WriteString("SENSE:BAND:VID 100kHz");                                    // Video bandwidth = 100 kHz
                    saSession.WriteString("SENSE:POW:RF:ATT 30");                                      // RF attenuation = 30 dB
                    saSession.WriteString($"DISP:WIND:TRAC:Y:RLEV:OFFS {saOffset}");                   // Apply offset

                    // Perform sweep for Noise Floor
                    saSession.WriteString(":INIT:IMM");                                                // Start sweep
                    saSession.WriteString("*OPC?");                                                    // Wait for operation complete
                    saSession.ReadString();                                                            // Until instrument answer for above query
                    saSession.WriteString(":TRAC:DATA? TRACE1");                                       // Get trace data
                    string traceData = saSession.ReadString();                                         // Read response

                    // Parse trace data and calculate top 30 points average for Noise Floor
                    double[] points = traceData.Split(',')                                             // Split the trace data string by commas into individual values
                                               .Select(double.Parse)                                   // Convert each string value to double
                                               .ToArray();                                             // Store as an array of doubles

                    double[] top30 = points.OrderByDescending(x => x)                                  // Sort points in descending order (highest first)
                                           .Take(30)                                                   // Take the top 30 highest points
                                           .ToArray();                                                 // Convert to array

                    double noiseFloor = Math.Round(top30.Average(), 3, MidpointRounding.AwayFromZero); // Calculate the average of top 30 points, round to 3 decimal places

                    // Turn SG ON
                    sgSession.WriteString("OUTP ON");                                                  // Enable SG output
                    System.Threading.Thread.Sleep(2000);                                               // Wait 2 seconds for signal stabilization

                    // Trigger SA sweep
                    saSession.WriteString(":INIT:IMM");                                                // Start immediate sweep
                    saSession.WriteString("*OPC?");                                                    // Query operation complete
                    string opc = saSession.ReadString();                                               // Read response
                    System.Threading.Thread.Sleep(2000);                                               // Additional wait for stability

                    // Marker setup
                    saSession.WriteString("CALC:MARK1:STATE ON");                                      // Enable marker 1
                    saSession.WriteString($":CALC:MARK1:X {freq}E6");                                  // Position marker at fundamental frequency (MHz → Hz)

                    // Read marker value
                    saSession.WriteString("CALC:MARK1:Y?");                                            // Query marker amplitude
                    double measuredPower = Math.Round(double.Parse(saSession.ReadString()), 2, MidpointRounding.AwayFromZero);// Parse and round to 2 decimal places
                    System.Threading.Thread.Sleep(2000);                                               // Wait for stability

                    // Turn SG OFF after measurement
                    sgSession.WriteString("OUTP OFF");

                    // Add measurement results to DataGridView
                    int rowIndex = dataGridView1.Rows.Add();                                           // Add new row
                    dataGridView1.Rows[rowIndex].Cells[0].Value = freq;                                // Store fundamental frequency
                    dataGridView1.Rows[rowIndex].Cells[1].Value = measuredPower.ToString("F2");        // Store measured power & show only .XX
                    dataGridView1.Rows[rowIndex].Cells[8].Value = offset;                              // Store offset value
                    dataGridView1.Rows[rowIndex].Cells[9].Value = noiseFloor.ToString("F3");           // Store noise floor & show only .XXX

                    // Measure harmonics (2x, 3x, 4x)
                    for (int i = 2; i <= 4; i++)
                    {
                        double harmonicFreq = freq * i;                                                // Calculate harmonic frequency
                        if (harmonicFreq > 8400) continue;                                             // Skip if harmonic exceeds SA scope range (~8.4 GHz)

                        // SG setup for harmonic measurement
                        sgSession.WriteString($"FREQ:CW {freq}MHz");                                   // Keep SG at fundamental frequency
                        sgSession.WriteString("OUTP ON");                                              // Enable SG output
                        System.Threading.Thread.Sleep(2000);                                           // Wait for stabilization

                        // SA setup for harmonic frequency
                        saSession.WriteString($"FREQ:CENT {harmonicFreq}MHz");                         // Set SA center frequency to harmonic

                        // Trigger sweep and wait
                        saSession.WriteString(":INIT:IMM");                                            // Start sweep
                        saSession.WriteString("*OPC?");                                                // Wait for completion
                        opc = saSession.ReadString();                                                  // Read response
                        System.Threading.Thread.Sleep(2000);                                           // Wait for stability

                        // Marker setup for harmonic
                        saSession.WriteString("CALC:MARK1:STATE ON");                                  // Enable marker
                        saSession.WriteString("CALC:MARK1:MODE POS");                                  // Peak mode
                        saSession.WriteString($":CALC:MARK1:X {harmonicFreq}E6");                      // Position marker at harmonic frequency

                        // Read harmonic power
                        saSession.WriteString("CALC:MARK1:Y?");                                        // Query marker amplitude
                        double harmonicPower = Math.Round(double.Parse(saSession.ReadString()), 2, MidpointRounding.AwayFromZero);// Parse and round to 2 decimal places
                        System.Threading.Thread.Sleep(2000);                                           // Wait for stability

                        // Turn SG OFF after measurement
                        sgSession.WriteString("OUTP OFF");

                        // Store harmonic data in DataGridView
                        dataGridView1.Rows[rowIndex].Cells[(i - 1) * 2].Value = harmonicFreq;                     // Store harmonic frequency
                        dataGridView1.Rows[rowIndex].Cells[(i - 1) * 2 + 1].Value = harmonicPower.ToString("F2"); // Store harmonic power & show only .XX
                    }
                }
                MessageBox.Show("Measurement Completed");                                              // Notify user
                textBox_save_location.Enabled = true;                                                  // Enable save location input
                button_Save.Enabled = true;                                                            // Enable save button
            }
            catch (Exception ex)
            {
                MessageBox.Show("Measurement Failed: " + ex.Message);                                  // Show error message
            }
        }

        // Save Data to Excel
        private void button_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = textBox_save_location.Text.Trim();                                       // Get save path from textbox
                if (!Directory.Exists(path))                                                           // Validate directory path
                {
                    MessageBox.Show("Invalid Path");                                                   // Show error message
                    return;
                }

                string filePath = Path.Combine(path, "Harmonic_test_Result.xlsx");                     // Build file path

                // Remove existing file if present
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                var wb = new XLWorkbook();                                                             // Create new Excel workbook
                var ws = wb.Worksheets.Add("Result");                                                  // Add worksheet named "Result"

                // Write headers
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    var headerCell = ws.Cell(1, i + 1);                                                // First row for headers
                    headerCell.Value = dataGridView1.Columns[i].HeaderText;                            // Set header text
                    headerCell.Style.Font.Bold = true;                                                 // Style headers: bold font
                    headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;                         // Style headers: light gray background
                }

                // Write data rows
                for (int r = 0; r < dataGridView1.Rows.Count; r++)
                {
                    if (dataGridView1.Rows[r].IsNewRow) continue;                                      // Skip empty row
                    for (int c = 0; c < dataGridView1.Columns.Count; c++)
                    {
                        var cellValue = dataGridView1.Rows[r].Cells[c].Value?.ToString() ?? "";        // If the cell is null, use empty string ("") to avoid exceptions

                        if (c == 1 && double.TryParse(cellValue, out double power))                    // Column 1 (Measured Power) → format to 2 decimal places
                        {
                            ws.Cell(r + 2, c + 1).Value = power.ToString("F2");
                        }
                        
                        else if (c == 9 && double.TryParse(cellValue, out double noise))               // Column 9 (Noise Floor) → format to 3 decimal places
                        {
                            ws.Cell(r + 2, c + 1).Value = noise.ToString("F3");
                        }
                        else
                        {
                            ws.Cell(r + 2, c + 1).Value = cellValue;                                   // Write as string
                        }
                    }
                }

                // Auto adjust column width
                ws.Columns().AdjustToContents();

                // Apply border to data range
                var range = ws.Range(1, 1, dataGridView1.Rows.Count, dataGridView1.Columns.Count);
                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.OutsideBorderColor = XLColor.Black;
                range.Style.Border.InsideBorderColor = XLColor.Black;

                // Save workbook to file
                wb.SaveAs(filePath);
                MessageBox.Show("Excel Save Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel Save Failed: " + ex.Message);                                  // Show error message
            }
        }

        // Reset
        private void button_Reset_Click_1(object sender, EventArgs e)
        {
            freqPowerList.Clear();                                                                    // Clear frequency-power list
            dataGridView1.Rows.Clear();                                                               // Clear DataGridView rows

            textFreq1.Clear();                                                                        // Clear all textboxes
            textFreq2.Clear();
            textFreq3.Clear();
            textFreq4.Clear();
            textFreq5.Clear();
            textPower1.Clear();
            textPower2.Clear();
            textPower3.Clear();
            textPower4.Clear();
            textPower5.Clear();

            button_Close.Enabled = true;                                                              // Reset button states
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

            textFreq1.Enabled = true;                                                                 // Reset textbox states
            textFreq2.Enabled = false;
            textFreq3.Enabled = false;
            textFreq4.Enabled = false;
            textFreq5.Enabled = false;

            textPower1.Enabled = true;
            textPower2.Enabled = false;
            textPower3.Enabled = false;
            textPower4.Enabled = false;
            textPower5.Enabled = false;

            textBox_save_location.Enabled = false;                                                   // Disable save path input
        }

        // Close
        private void button_Close_Click_1(object sender, EventArgs e)
        {
            try
            {
                sgSession?.WriteString("*RST");                                                      // Reset SG if connected
                saSession?.WriteString("*RST");                                                      // Reset SA if connected
            }
            catch { }
            Application.Exit();                                                                      // Exit application
        }
    }
}
