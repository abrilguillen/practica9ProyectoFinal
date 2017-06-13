namespace arbolExpresion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtResultadoPre = new System.Windows.Forms.TextBox();
            this.txtResultadoPost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdEvaluarPre = new System.Windows.Forms.Button();
            this.cmdEvaluarPost = new System.Windows.Forms.Button();
            this.cmdGenerarArbol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(107, 15);
            this.txtExpresion.Multiline = true;
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(198, 20);
            this.txtExpresion.TabIndex = 0;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(60, 85);
            this.txtPre.Multiline = true;
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(245, 20);
            this.txtPre.TabIndex = 1;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(60, 129);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(245, 20);
            this.txtPost.TabIndex = 2;
            // 
            // txtResultadoPre
            // 
            this.txtResultadoPre.Location = new System.Drawing.Point(453, 88);
            this.txtResultadoPre.Name = "txtResultadoPre";
            this.txtResultadoPre.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoPre.TabIndex = 3;
            // 
            // txtResultadoPost
            // 
            this.txtResultadoPost.Location = new System.Drawing.Point(453, 125);
            this.txtResultadoPost.Name = "txtResultadoPost";
            this.txtResultadoPost.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoPost.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expresión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Post";
            // 
            // cmdEvaluarPre
            // 
            this.cmdEvaluarPre.Location = new System.Drawing.Point(346, 85);
            this.cmdEvaluarPre.Name = "cmdEvaluarPre";
            this.cmdEvaluarPre.Size = new System.Drawing.Size(75, 23);
            this.cmdEvaluarPre.TabIndex = 8;
            this.cmdEvaluarPre.Text = "Evaluar";
            this.cmdEvaluarPre.UseVisualStyleBackColor = true;
            this.cmdEvaluarPre.Click += new System.EventHandler(this.cmdEvaluarPre_Click);
            // 
            // cmdEvaluarPost
            // 
            this.cmdEvaluarPost.Location = new System.Drawing.Point(346, 127);
            this.cmdEvaluarPost.Name = "cmdEvaluarPost";
            this.cmdEvaluarPost.Size = new System.Drawing.Size(75, 23);
            this.cmdEvaluarPost.TabIndex = 9;
            this.cmdEvaluarPost.Text = "Evaluar";
            this.cmdEvaluarPost.UseVisualStyleBackColor = true;
            this.cmdEvaluarPost.Click += new System.EventHandler(this.cmdEvaluarPost_Click);
            // 
            // cmdGenerarArbol
            // 
            this.cmdGenerarArbol.Location = new System.Drawing.Point(151, 41);
            this.cmdGenerarArbol.Name = "cmdGenerarArbol";
            this.cmdGenerarArbol.Size = new System.Drawing.Size(108, 23);
            this.cmdGenerarArbol.TabIndex = 10;
            this.cmdGenerarArbol.Text = "Generar Árbol";
            this.cmdGenerarArbol.UseVisualStyleBackColor = true;
            this.cmdGenerarArbol.Click += new System.EventHandler(this.cmdGenerarArbol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 193);
            this.Controls.Add(this.cmdGenerarArbol);
            this.Controls.Add(this.cmdEvaluarPost);
            this.Controls.Add(this.cmdEvaluarPre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultadoPost);
            this.Controls.Add(this.txtResultadoPre);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtExpresion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtResultadoPre;
        private System.Windows.Forms.TextBox txtResultadoPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdEvaluarPre;
        private System.Windows.Forms.Button cmdEvaluarPost;
        private System.Windows.Forms.Button cmdGenerarArbol;
    }
}

