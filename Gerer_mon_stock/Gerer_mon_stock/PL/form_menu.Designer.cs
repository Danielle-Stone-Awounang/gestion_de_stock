﻿namespace Gerer_mon_stock.PL
{
    partial class form_menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pan_btn = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_utilisateur = new System.Windows.Forms.Button();
            this.btn_commande = new System.Windows.Forms.Button();
            this.btn_categorie = new System.Windows.Forms.Button();
            this.btn_produit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pan_parametre = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pan_parametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.pan_btn);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Controls.Add(this.btn_client);
            this.panel1.Controls.Add(this.btn_utilisateur);
            this.panel1.Controls.Add(this.btn_commande);
            this.panel1.Controls.Add(this.btn_categorie);
            this.panel1.Controls.Add(this.btn_produit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 563);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 12);
            this.panel2.TabIndex = 1;
            // 
            // pan_btn
            // 
            this.pan_btn.BackColor = System.Drawing.Color.Maroon;
            this.pan_btn.Location = new System.Drawing.Point(0, 77);
            this.pan_btn.Name = "pan_btn";
            this.pan_btn.Size = new System.Drawing.Size(10, 55);
            this.pan_btn.TabIndex = 3;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Image = global::Gerer_mon_stock.Properties.Resources.menu_16px;
            this.btn_menu.Location = new System.Drawing.Point(205, 7);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(34, 28);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_client
            // 
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_client.Image = global::Gerer_mon_stock.Properties.Resources.user_48px;
            this.btn_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.Location = new System.Drawing.Point(12, 77);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(229, 55);
            this.btn_client.TabIndex = 7;
            this.btn_client.Text = "         client";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_utilisateur
            // 
            this.btn_utilisateur.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_utilisateur.Image = global::Gerer_mon_stock.Properties.Resources.user_shield_48px;
            this.btn_utilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_utilisateur.Location = new System.Drawing.Point(12, 349);
            this.btn_utilisateur.Name = "btn_utilisateur";
            this.btn_utilisateur.Size = new System.Drawing.Size(229, 55);
            this.btn_utilisateur.TabIndex = 6;
            this.btn_utilisateur.Text = "         utilisateur";
            this.btn_utilisateur.UseVisualStyleBackColor = true;
            this.btn_utilisateur.Click += new System.EventHandler(this.btn_utilisateur_Click);
            // 
            // btn_commande
            // 
            this.btn_commande.FlatAppearance.BorderSize = 0;
            this.btn_commande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commande.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_commande.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_commande.Image = global::Gerer_mon_stock.Properties.Resources.purchase_order_26px1;
            this.btn_commande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_commande.Location = new System.Drawing.Point(12, 279);
            this.btn_commande.Name = "btn_commande";
            this.btn_commande.Size = new System.Drawing.Size(229, 55);
            this.btn_commande.TabIndex = 5;
            this.btn_commande.Text = "          commande";
            this.btn_commande.UseVisualStyleBackColor = true;
            this.btn_commande.Click += new System.EventHandler(this.btn_commande_Click);
            // 
            // btn_categorie
            // 
            this.btn_categorie.FlatAppearance.BorderSize = 0;
            this.btn_categorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categorie.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categorie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_categorie.Image = global::Gerer_mon_stock.Properties.Resources.categorize_48px;
            this.btn_categorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categorie.Location = new System.Drawing.Point(12, 211);
            this.btn_categorie.Name = "btn_categorie";
            this.btn_categorie.Size = new System.Drawing.Size(229, 55);
            this.btn_categorie.TabIndex = 4;
            this.btn_categorie.Text = "         categorie";
            this.btn_categorie.UseVisualStyleBackColor = true;
            this.btn_categorie.Click += new System.EventHandler(this.btn_categorie_Click);
            // 
            // btn_produit
            // 
            this.btn_produit.FlatAppearance.BorderSize = 0;
            this.btn_produit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produit.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_produit.Image = global::Gerer_mon_stock.Properties.Resources.clear_shopping_cart_40px;
            this.btn_produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produit.Location = new System.Drawing.Point(12, 153);
            this.btn_produit.Name = "btn_produit";
            this.btn_produit.Size = new System.Drawing.Size(229, 52);
            this.btn_produit.TabIndex = 3;
            this.btn_produit.Text = "           produit";
            this.btn_produit.UseVisualStyleBackColor = true;
            this.btn_produit.Click += new System.EventHandler(this.btn_produit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pan_parametre);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_minus);
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(245, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 551);
            this.panel3.TabIndex = 2;
            // 
            // pan_parametre
            // 
            this.pan_parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pan_parametre.Controls.Add(this.button5);
            this.pan_parametre.Controls.Add(this.button4);
            this.pan_parametre.Controls.Add(this.button3);
            this.pan_parametre.Controls.Add(this.button2);
            this.pan_parametre.Location = new System.Drawing.Point(40, 0);
            this.pan_parametre.Name = "pan_parametre";
            this.pan_parametre.Size = new System.Drawing.Size(371, 208);
            this.pan_parametre.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::Gerer_mon_stock.Properties.Resources.cloud_backup_restore_24px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(365, 44);
            this.button5.TabIndex = 3;
            this.button5.Text = "restaurer une copie enregistrée";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::Gerer_mon_stock.Properties.Resources.cancel_24px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(365, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "déconnecter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::Gerer_mon_stock.Properties.Resources.import_24px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(365, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "créer une copie de l\'application";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Gerer_mon_stock.Properties.Resources.connect_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "connecter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Gerer_mon_stock.Properties.Resources.settings_24px;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_minus
            // 
            this.btn_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Image = global::Gerer_mon_stock.Properties.Resources.minus_24px;
            this.btn_minus.Location = new System.Drawing.Point(732, 0);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(15, 23);
            this.btn_minus.TabIndex = 11;
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Gerer_mon_stock.Properties.Resources.delete_16px;
            this.btn_close.Location = new System.Drawing.Point(753, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(21, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_menu";
            this.Text = "form_menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pan_parametre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_produit;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_utilisateur;
        private System.Windows.Forms.Button btn_commande;
        private System.Windows.Forms.Button btn_categorie;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel pan_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pan_parametre;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_close;
    }
}