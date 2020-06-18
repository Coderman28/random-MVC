namespace RANDOM_MVC
{
    partial class Form1
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
            this.button = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.ForeColor = System.Drawing.Color.Red;
            this.button.Location = new System.Drawing.Point(117, 167);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(126, 82);
            this.button.TabIndex = 0;
            this.button.Text = "clique moi";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(132, 49);
            this.text.MaximumSize = new System.Drawing.Size(100, 100);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(92, 13);
            this.text.TabIndex = 1;
            this.text.Text = "tape sur le bouton";
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 293);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "RANDOM MVC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label text;
    }
}

