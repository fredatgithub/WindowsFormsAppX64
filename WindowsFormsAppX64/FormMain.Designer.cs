
namespace WindowsFormsAppX64
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelRamUsed = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelRamUsed
      // 
      this.labelRamUsed.AutoSize = true;
      this.labelRamUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelRamUsed.Location = new System.Drawing.Point(5, 37);
      this.labelRamUsed.Name = "labelRamUsed";
      this.labelRamUsed.Size = new System.Drawing.Size(370, 24);
      this.labelRamUsed.TabIndex = 0;
      this.labelRamUsed.Text = "This application is using  X GB of RAM";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(436, 105);
      this.Controls.Add(this.labelRamUsed);
      this.Name = "FormMain";
      this.Text = "App X64";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelRamUsed;
  }
}

