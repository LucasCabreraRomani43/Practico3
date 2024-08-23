namespace Practico3
{
    partial class formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario));
            label1 = new Label();
            panel1 = new Panel();
            Cmaster = new CheckBox();
            Cvisa = new CheckBox();
            Cnaranja = new CheckBox();
            Tapellido = new TextBox();
            Ttelefono = new TextBox();
            Tnombre = new TextBox();
            Tdni = new TextBox();
            Ltarjeta = new Label();
            Ltelefono = new Label();
            Lnombre = new Label();
            Ldni = new Label();
            Lapellido = new Label();
            Lmodificar = new Label();
            LnomyapModificar = new Label();
            Bguardar = new Button();
            Beliminar = new Button();
            Bsalir = new Button();
            pictureBox1 = new PictureBox();
            RBmujer = new RadioButton();
            RBvaron = new RadioButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(339, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Nuevo usuario";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Cmaster);
            panel1.Controls.Add(Cvisa);
            panel1.Controls.Add(Cnaranja);
            panel1.Controls.Add(Tapellido);
            panel1.Controls.Add(Ttelefono);
            panel1.Controls.Add(Tnombre);
            panel1.Controls.Add(Tdni);
            panel1.Controls.Add(Ltarjeta);
            panel1.Controls.Add(Ltelefono);
            panel1.Controls.Add(Lnombre);
            panel1.Controls.Add(Ldni);
            panel1.Controls.Add(Lapellido);
            panel1.Controls.Add(Lmodificar);
            panel1.Controls.Add(LnomyapModificar);
            panel1.Location = new Point(51, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 275);
            panel1.TabIndex = 1;
            // 
            // Cmaster
            // 
            Cmaster.AutoSize = true;
            Cmaster.Font = new Font("Palatino Linotype", 9F);
            Cmaster.Location = new Point(175, 245);
            Cmaster.Name = "Cmaster";
            Cmaster.Size = new Size(92, 21);
            Cmaster.TabIndex = 13;
            Cmaster.Text = "Mastercard";
            Cmaster.UseVisualStyleBackColor = true;
            // 
            // Cvisa
            // 
            Cvisa.AutoSize = true;
            Cvisa.Font = new Font("Palatino Linotype", 9F);
            Cvisa.Location = new Point(175, 218);
            Cvisa.Name = "Cvisa";
            Cvisa.Size = new Size(52, 21);
            Cvisa.TabIndex = 12;
            Cvisa.Text = "Visa";
            Cvisa.UseVisualStyleBackColor = true;
            // 
            // Cnaranja
            // 
            Cnaranja.AutoSize = true;
            Cnaranja.Font = new Font("Palatino Linotype", 9F);
            Cnaranja.Location = new Point(175, 191);
            Cnaranja.Name = "Cnaranja";
            Cnaranja.Size = new Size(72, 21);
            Cnaranja.TabIndex = 11;
            Cnaranja.Text = "Naranja";
            Cnaranja.UseVisualStyleBackColor = true;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(89, 74);
            Tapellido.Name = "Tapellido";
            Tapellido.Size = new Size(190, 22);
            Tapellido.TabIndex = 10;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // Ttelefono
            // 
            Ttelefono.Location = new Point(89, 148);
            Ttelefono.Name = "Ttelefono";
            Ttelefono.Size = new Size(190, 22);
            Ttelefono.TabIndex = 9;
            Ttelefono.KeyPress += Ttelefono_KeyPress;
            // 
            // Tnombre
            // 
            Tnombre.Location = new Point(89, 109);
            Tnombre.Name = "Tnombre";
            Tnombre.Size = new Size(190, 22);
            Tnombre.TabIndex = 8;
            Tnombre.KeyPress += Tnombre_KeyPress;
            // 
            // Tdni
            // 
            Tdni.Location = new Point(89, 41);
            Tdni.Name = "Tdni";
            Tdni.Size = new Size(190, 22);
            Tdni.TabIndex = 7;
            Tdni.KeyPress += Tdni_KeyPress;
            // 
            // Ltarjeta
            // 
            Ltarjeta.AutoSize = true;
            Ltarjeta.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ltarjeta.Location = new Point(47, 188);
            Ltarjeta.Name = "Ltarjeta";
            Ltarjeta.Size = new Size(106, 17);
            Ltarjeta.TabIndex = 6;
            Ltarjeta.Text = "Medios de pagos:";
            // 
            // Ltelefono
            // 
            Ltelefono.AutoSize = true;
            Ltelefono.Font = new Font("Palatino Linotype", 9F);
            Ltelefono.Location = new Point(22, 151);
            Ltelefono.Name = "Ltelefono";
            Ltelefono.Size = new Size(59, 17);
            Ltelefono.TabIndex = 5;
            Ltelefono.Text = "Telefono:";
            // 
            // Lnombre
            // 
            Lnombre.AutoSize = true;
            Lnombre.Font = new Font("Palatino Linotype", 9F);
            Lnombre.Location = new Point(22, 114);
            Lnombre.Name = "Lnombre";
            Lnombre.Size = new Size(61, 17);
            Lnombre.TabIndex = 4;
            Lnombre.Text = "*Nombre:";
            // 
            // Ldni
            // 
            Ldni.AutoSize = true;
            Ldni.Font = new Font("Palatino Linotype", 9F);
            Ldni.Location = new Point(22, 46);
            Ldni.Name = "Ldni";
            Ldni.Size = new Size(44, 17);
            Ldni.TabIndex = 3;
            Ldni.Text = "*D.N.I:";
            // 
            // Lapellido
            // 
            Lapellido.AutoSize = true;
            Lapellido.Font = new Font("Palatino Linotype", 9F);
            Lapellido.Location = new Point(22, 74);
            Lapellido.Name = "Lapellido";
            Lapellido.Size = new Size(61, 17);
            Lapellido.TabIndex = 2;
            Lapellido.Text = "*Apellido:";
            // 
            // Lmodificar
            // 
            Lmodificar.AutoSize = true;
            Lmodificar.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lmodificar.ForeColor = Color.Firebrick;
            Lmodificar.Location = new Point(144, 10);
            Lmodificar.Name = "Lmodificar";
            Lmodificar.Size = new Size(61, 17);
            Lmodificar.TabIndex = 1;
            Lmodificar.Text = "modificar";
            // 
            // LnomyapModificar
            // 
            LnomyapModificar.AutoSize = true;
            LnomyapModificar.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LnomyapModificar.Location = new Point(22, 10);
            LnomyapModificar.Name = "LnomyapModificar";
            LnomyapModificar.Size = new Size(116, 17);
            LnomyapModificar.TabIndex = 0;
            LnomyapModificar.Text = "Nombre y Apellido:";
            // 
            // Bguardar
            // 
            Bguardar.Location = new Point(66, 309);
            Bguardar.Name = "Bguardar";
            Bguardar.Size = new Size(138, 64);
            Bguardar.TabIndex = 2;
            Bguardar.Text = "Guardar";
            Bguardar.TextAlign = ContentAlignment.MiddleRight;
            Bguardar.UseVisualStyleBackColor = true;
            Bguardar.Click += Bguardar_Click;
            // 
            // Beliminar
            // 
            Beliminar.Location = new Point(304, 309);
            Beliminar.Name = "Beliminar";
            Beliminar.Size = new Size(138, 64);
            Beliminar.TabIndex = 3;
            Beliminar.Text = "Eliminar";
            Beliminar.TextAlign = ContentAlignment.MiddleRight;
            Beliminar.UseVisualStyleBackColor = true;
            Beliminar.Click += Beliminar_Click;
            // 
            // Bsalir
            // 
            Bsalir.Image = (Image)resources.GetObject("Bsalir.Image");
            Bsalir.ImageAlign = ContentAlignment.MiddleLeft;
            Bsalir.Location = new Point(545, 300);
            Bsalir.Name = "Bsalir";
            Bsalir.Size = new Size(119, 64);
            Bsalir.TabIndex = 4;
            Bsalir.Text = "SALIR";
            Bsalir.TextAlign = ContentAlignment.MiddleRight;
            Bsalir.UseVisualStyleBackColor = true;
            Bsalir.Click += Bsalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Hombre;
            pictureBox1.Image = Properties.Resources.Hombre;
            pictureBox1.Location = new Point(453, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 205);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RBmujer
            // 
            RBmujer.AutoSize = true;
            RBmujer.Location = new Point(453, 248);
            RBmujer.Name = "RBmujer";
            RBmujer.Size = new Size(89, 19);
            RBmujer.TabIndex = 6;
            RBmujer.TabStop = true;
            RBmujer.Text = "Femenino";
            RBmujer.UseVisualStyleBackColor = true;
            RBmujer.CheckedChanged += RBmujer_CheckedChanged;
            // 
            // RBvaron
            // 
            RBvaron.AutoSize = true;
            RBvaron.Location = new Point(600, 248);
            RBvaron.Name = "RBvaron";
            RBvaron.Size = new Size(95, 19);
            RBvaron.TabIndex = 7;
            RBvaron.TabStop = true;
            RBvaron.Text = "Masculino";
            RBvaron.UseVisualStyleBackColor = true;
            RBvaron.CheckedChanged += RBvaron_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Eliminar1;
            pictureBox2.Location = new Point(313, 321);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 43);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Guardar;
            pictureBox3.Location = new Point(73, 314);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 50);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // formulario
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 379);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(RBvaron);
            Controls.Add(RBmujer);
            Controls.Add(pictureBox1);
            Controls.Add(Bsalir);
            Controls.Add(Beliminar);
            Controls.Add(Bguardar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "formulario";
            Text = "pequeño formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label Lmodificar;
        private Label LnomyapModificar;
        private Label Ltelefono;
        private Label Lnombre;
        private Label Ldni;
        private Label Lapellido;
        private TextBox Tapellido;
        private TextBox Ttelefono;
        private TextBox Tnombre;
        private TextBox Tdni;
        private Label Ltarjeta;
        private CheckBox Cmaster;
        private CheckBox Cvisa;
        private CheckBox Cnaranja;
        private Button Bguardar;
        private Button Beliminar;
        private Button Bsalir;
        private PictureBox pictureBox1;
        private RadioButton RBmujer;
        private RadioButton RBvaron;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
