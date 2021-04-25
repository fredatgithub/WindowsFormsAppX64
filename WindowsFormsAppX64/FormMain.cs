using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsAppX64
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    string chaine;
    int dimension = 1000;
    string[,,] tableau = new string[200, 1000, 1000];

    private void FormMain_Load(object sender, EventArgs e)
    {
      string alphabet = "abcdefghijklmnopqrstuvwxyz";
      for (int i = 0; i < 100000; i++)
      {
        chaine += alphabet;
      }

      for (int i = 0; i < 200; i++)
      {
        for (int j = 0; j < dimension; j++)
        {
          for (int k = 0; k < dimension; k++)
          {
            tableau[i, j, k] = chaine;
          }
        }
      }

      Process proc = Process.GetCurrentProcess();
      labelRamUsed.Text = $"This application is using  {SizeSuffix(proc.WorkingSet64)}";
    }

    private static string SizeSuffix(long value, int decimalPlaces = 1)
    {
      string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
      if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException(nameof(decimalPlaces)); }
      if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
      if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

      // magnitude is 0 for bytes, 1 for KB, 2, for MB, etc.
      int magnitude = (int)Math.Log(value, 1024);

      // 1L << (mag * 10) == 2 ^ (10 * mag) 
      // [i.e. the number of bytes in the unit corresponding to mag]
      decimal adjustedSize = (decimal)value / (1L << (magnitude * 10));

      // make adjustment when the value is large enough that
      // it would round up to 1000 or more
      if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
      {
        magnitude += 1;
        adjustedSize /= 1024;
      }

      return string.Format("{0:n" + decimalPlaces + "} {1}", adjustedSize, SizeSuffixes[magnitude]);
    }
  }
}
