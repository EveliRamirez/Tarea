namespace Tarea
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lienzo = new System.Windows.Forms.PictureBox();
            this.picBlack = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPincel = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.trackBartampincel = new System.Windows.Forms.TrackBar();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btncirculo = new System.Windows.Forms.Button();
            this.btncuadrado = new System.Windows.Forms.Button();
            this.btntriangulo = new System.Windows.Forms.Button();
            this.txtTamanoPincel = new System.Windows.Forms.TextBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnRellenado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBartampincel)).BeginInit();
            this.SuspendLayout();
            // 
            // lienzo
            // 
            this.lienzo.BackColor = System.Drawing.SystemColors.Window;
            this.lienzo.Location = new System.Drawing.Point(456, 67);
            this.lienzo.Name = "lienzo";
            this.lienzo.Size = new System.Drawing.Size(921, 488);
            this.lienzo.TabIndex = 0;
            this.lienzo.TabStop = false;
            this.lienzo.Click += new System.EventHandler(this.lienzo_Click);
            this.lienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lienzo_MouseDown);
            this.lienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lienzo_MouseMove);
            this.lienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lienzo_MouseUp);
            // 
            // picBlack
            // 
            this.picBlack.BackColor = System.Drawing.Color.Black;
            this.picBlack.Location = new System.Drawing.Point(314, 178);
            this.picBlack.Name = "picBlack";
            this.picBlack.Size = new System.Drawing.Size(31, 29);
            this.picBlack.TabIndex = 1;
            this.picBlack.TabStop = false;
            this.picBlack.Click += new System.EventHandler(this.picBlack_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Red;
            this.picBox.Location = new System.Drawing.Point(380, 178);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(34, 29);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // btnPincel
            // 
            this.btnPincel.Location = new System.Drawing.Point(56, 73);
            this.btnPincel.Name = "btnPincel";
            this.btnPincel.Size = new System.Drawing.Size(75, 23);
            this.btnPincel.TabIndex = 6;
            this.btnPincel.Text = "pincel";
            this.btnPincel.UseVisualStyleBackColor = true;
            this.btnPincel.Click += new System.EventHandler(this.btnPincel_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(56, 103);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // trackBartampincel
            // 
            this.trackBartampincel.Location = new System.Drawing.Point(171, 67);
            this.trackBartampincel.Name = "trackBartampincel";
            this.trackBartampincel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBartampincel.Size = new System.Drawing.Size(45, 140);
            this.trackBartampincel.TabIndex = 8;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(314, 106);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 9;
            this.txtG.Text = "0";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(314, 66);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 10;
            this.txtR.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(314, 142);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 11;
            this.txtB.Text = "0";
            // 
            // btncirculo
            // 
            this.btncirculo.Location = new System.Drawing.Point(56, 243);
            this.btncirculo.Name = "btncirculo";
            this.btncirculo.Size = new System.Drawing.Size(75, 23);
            this.btncirculo.TabIndex = 12;
            this.btncirculo.Text = "circulo";
            this.btncirculo.UseVisualStyleBackColor = true;
            this.btncirculo.Click += new System.EventHandler(this.btncirculo_Click);
            // 
            // btncuadrado
            // 
            this.btncuadrado.Location = new System.Drawing.Point(56, 214);
            this.btncuadrado.Name = "btncuadrado";
            this.btncuadrado.Size = new System.Drawing.Size(75, 23);
            this.btncuadrado.TabIndex = 13;
            this.btncuadrado.Text = "cuadrado";
            this.btncuadrado.UseVisualStyleBackColor = true;
            this.btncuadrado.Click += new System.EventHandler(this.btncuadrado_Click);
            // 
            // btntriangulo
            // 
            this.btntriangulo.Location = new System.Drawing.Point(56, 272);
            this.btntriangulo.Name = "btntriangulo";
            this.btntriangulo.Size = new System.Drawing.Size(75, 23);
            this.btntriangulo.TabIndex = 14;
            this.btntriangulo.Text = "triangulo";
            this.btntriangulo.UseVisualStyleBackColor = true;
            this.btntriangulo.Click += new System.EventHandler(this.btntriangulo_Click);
            // 
            // txtTamanoPincel
            // 
            this.txtTamanoPincel.Location = new System.Drawing.Point(171, 213);
            this.txtTamanoPincel.Name = "txtTamanoPincel";
            this.txtTamanoPincel.Size = new System.Drawing.Size(100, 20);
            this.txtTamanoPincel.TabIndex = 15;
            this.txtTamanoPincel.Text = "0";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(259, 272);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(191, 23);
            this.btnCargarImagen.TabIndex = 16;
            this.btnCargarImagen.Text = "Seleccionar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // btnRellenado
            // 
            this.btnRellenado.Location = new System.Drawing.Point(56, 149);
            this.btnRellenado.Name = "btnRellenado";
            this.btnRellenado.Size = new System.Drawing.Size(63, 23);
            this.btnRellenado.TabIndex = 17;
            this.btnRellenado.Text = "Rellenar";
            this.btnRellenado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1441, 626);
            this.Controls.Add(this.btnRellenado);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.txtTamanoPincel);
            this.Controls.Add(this.btntriangulo);
            this.Controls.Add(this.btncuadrado);
            this.Controls.Add(this.btncirculo);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.trackBartampincel);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnPincel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.picBlack);
            this.Controls.Add(this.lienzo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBartampincel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lienzo;
        private System.Windows.Forms.PictureBox picBlack;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPincel;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TrackBar trackBartampincel;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btncirculo;
        private System.Windows.Forms.Button btncuadrado;
        private System.Windows.Forms.Button btntriangulo;
        private System.Windows.Forms.TextBox txtTamanoPincel;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnRellenado;
    }
}

