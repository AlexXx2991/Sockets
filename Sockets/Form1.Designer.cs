namespace Sockets
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
            btnIniciarServidor = new Button();
            btnClienteNuevo = new Button();
            txtMensajes = new TextBox();
            SuspendLayout();
            // 
            // btnIniciarServidor
            // 
            btnIniciarServidor.Location = new Point(12, 12);
            btnIniciarServidor.Name = "btnIniciarServidor";
            btnIniciarServidor.Size = new Size(175, 29);
            btnIniciarServidor.TabIndex = 0;
            btnIniciarServidor.Text = "Iniciar Servidor";
            btnIniciarServidor.UseVisualStyleBackColor = true;
            btnIniciarServidor.Click += btnIniciarServidor_Click;
            // 
            // btnClienteNuevo
            // 
            btnClienteNuevo.Location = new Point(202, 12);
            btnClienteNuevo.Name = "btnClienteNuevo";
            btnClienteNuevo.Size = new Size(175, 29);
            btnClienteNuevo.TabIndex = 1;
            btnClienteNuevo.Text = "Cliente Nuevo";
            btnClienteNuevo.UseVisualStyleBackColor = true;
            btnClienteNuevo.Click += btnClienteNuevo_Click;
            // 
            // txtMensajes
            // 
            txtMensajes.Location = new Point(12, 57);
            txtMensajes.Multiline = true;
            txtMensajes.Name = "txtMensajes";
            txtMensajes.Size = new Size(776, 381);
            txtMensajes.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMensajes);
            Controls.Add(btnClienteNuevo);
            Controls.Add(btnIniciarServidor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarServidor;
        private Button btnClienteNuevo;
        private TextBox txtMensajes;
    }
}
