namespace testes2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtX = new TextBox();
            txtY = new TextBox();
            txtText = new TextBox();
            btnCriar = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(278, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 23);
            txtName.TabIndex = 0;
            // 
            // txtX
            // 
            txtX.Location = new Point(384, 124);
            txtX.Name = "txtX";
            txtX.Size = new Size(92, 23);
            txtX.TabIndex = 1;
            // 
            // txtY
            // 
            txtY.Location = new Point(278, 124);
            txtY.Name = "txtY";
            txtY.Size = new Size(87, 23);
            txtY.TabIndex = 2;
            // 
            // txtText
            // 
            txtText.Location = new Point(278, 78);
            txtText.Name = "txtText";
            txtText.Size = new Size(198, 23);
            txtText.TabIndex = 3;
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(334, 176);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 4;
            btnCriar.Text = "Criar Botão";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCriar);
            Controls.Add(txtText);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtText;
        private Button btnCriar;
    }
}