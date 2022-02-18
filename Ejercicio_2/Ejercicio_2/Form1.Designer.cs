namespace Ejercicio_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.GuardarNombreButton = new System.Windows.Forms.Button();
            this.GuardarEdadButton = new System.Windows.Forms.Button();
            this.MostrarLitadoButton = new System.Windows.Forms.Button();
            this.ListadoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, a continuación guarde el nombre y la edad de 5 estudiantes:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(169, 91);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 23);
            this.NombreTextBox.TabIndex = 3;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(169, 148);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(100, 23);
            this.EdadTextBox.TabIndex = 4;
            // 
            // GuardarNombreButton
            // 
            this.GuardarNombreButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuardarNombreButton.Location = new System.Drawing.Point(384, 91);
            this.GuardarNombreButton.Name = "GuardarNombreButton";
            this.GuardarNombreButton.Size = new System.Drawing.Size(114, 30);
            this.GuardarNombreButton.TabIndex = 5;
            this.GuardarNombreButton.Text = "Guardar nombre";
            this.GuardarNombreButton.UseVisualStyleBackColor = false;
            this.GuardarNombreButton.Click += new System.EventHandler(this.GuardarNombreButton_Click);
            // 
            // GuardarEdadButton
            // 
            this.GuardarEdadButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuardarEdadButton.Location = new System.Drawing.Point(384, 143);
            this.GuardarEdadButton.Name = "GuardarEdadButton";
            this.GuardarEdadButton.Size = new System.Drawing.Size(114, 30);
            this.GuardarEdadButton.TabIndex = 6;
            this.GuardarEdadButton.Text = "Guardar edad";
            this.GuardarEdadButton.UseVisualStyleBackColor = false;
            this.GuardarEdadButton.Click += new System.EventHandler(this.GuardarEdadButton_Click);
            // 
            // MostrarLitadoButton
            // 
            this.MostrarLitadoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MostrarLitadoButton.Location = new System.Drawing.Point(213, 235);
            this.MostrarLitadoButton.Name = "MostrarLitadoButton";
            this.MostrarLitadoButton.Size = new System.Drawing.Size(114, 43);
            this.MostrarLitadoButton.TabIndex = 7;
            this.MostrarLitadoButton.Text = "Mostrar listado de estudiantes";
            this.MostrarLitadoButton.UseVisualStyleBackColor = false;
            this.MostrarLitadoButton.Click += new System.EventHandler(this.MostrarLitadoButton_Click);
            // 
            // ListadoComboBox
            // 
            this.ListadoComboBox.FormattingEnabled = true;
            this.ListadoComboBox.Location = new System.Drawing.Point(377, 246);
            this.ListadoComboBox.Name = "ListadoComboBox";
            this.ListadoComboBox.Size = new System.Drawing.Size(121, 23);
            this.ListadoComboBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(542, 316);
            this.Controls.Add(this.ListadoComboBox);
            this.Controls.Add(this.MostrarLitadoButton);
            this.Controls.Add(this.GuardarEdadButton);
            this.Controls.Add(this.GuardarNombreButton);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NombreTextBox;
        private TextBox EdadTextBox;
        private Button GuardarNombreButton;
        private Button GuardarEdadButton;
        private Button MostrarLitadoButton;
        private ComboBox ListadoComboBox;
    }
}