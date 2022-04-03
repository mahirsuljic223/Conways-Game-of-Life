
namespace Conway_s_Game_of_Life
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.pb_display = new System.Windows.Forms.PictureBox();
            this.slider_speed = new System.Windows.Forms.TrackBar();
            this.lb_gen = new System.Windows.Forms.Label();
            this.slider_size = new System.Windows.Forms.TrackBar();
            this.lb_speed = new System.Windows.Forms.Label();
            this.lb_size = new System.Windows.Forms.Label();
            this.lb_sizeCover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_size)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(15, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(156, 50);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(171, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(156, 50);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(327, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(156, 50);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(483, 12);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(156, 50);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.Btn_pause_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(639, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(156, 50);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // timer_main
            // 
            this.timer_main.Tick += new System.EventHandler(this.Timer_main_Tick);
            // 
            // pb_display
            // 
            this.pb_display.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_display.Location = new System.Drawing.Point(0, 161);
            this.pb_display.Name = "pb_display";
            this.pb_display.Size = new System.Drawing.Size(810, 540);
            this.pb_display.TabIndex = 5;
            this.pb_display.TabStop = false;
            this.pb_display.Click += new System.EventHandler(this.Pb_display_Click);
            this.pb_display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_display_MouseDown);
            this.pb_display.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pb_display_MouseMove);
            this.pb_display.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pb_display_MouseUp);
            // 
            // slider_speed
            // 
            this.slider_speed.Location = new System.Drawing.Point(17, 103);
            this.slider_speed.Maximum = 50;
            this.slider_speed.Minimum = 1;
            this.slider_speed.Name = "slider_speed";
            this.slider_speed.Size = new System.Drawing.Size(388, 45);
            this.slider_speed.TabIndex = 6;
            this.slider_speed.Value = 10;
            this.slider_speed.Scroll += new System.EventHandler(this.Slider_speed_Scroll);
            // 
            // lb_gen
            // 
            this.lb_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gen.Location = new System.Drawing.Point(0, 138);
            this.lb_gen.Name = "lb_gen";
            this.lb_gen.Size = new System.Drawing.Size(810, 20);
            this.lb_gen.TabIndex = 7;
            this.lb_gen.Text = "Generation : 0";
            this.lb_gen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // slider_size
            // 
            this.slider_size.Location = new System.Drawing.Point(409, 103);
            this.slider_size.Maximum = 225;
            this.slider_size.Minimum = 9;
            this.slider_size.Name = "slider_size";
            this.slider_size.Size = new System.Drawing.Size(388, 45);
            this.slider_size.TabIndex = 8;
            this.slider_size.Value = 90;
            this.slider_size.Scroll += new System.EventHandler(this.Slider_size_Scroll);
            // 
            // lb_speed
            // 
            this.lb_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_speed.Location = new System.Drawing.Point(14, 65);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(388, 35);
            this.lb_speed.TabIndex = 9;
            this.lb_speed.Text = "Speed\r\n10 gen/s";
            this.lb_speed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_size
            // 
            this.lb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_size.Location = new System.Drawing.Point(409, 65);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(388, 35);
            this.lb_size.TabIndex = 10;
            this.lb_size.Text = "Size\r\n90x60";
            this.lb_size.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_sizeCover
            // 
            this.lb_sizeCover.BackColor = System.Drawing.Color.Transparent;
            this.lb_sizeCover.Location = new System.Drawing.Point(411, 103);
            this.lb_sizeCover.Name = "lb_sizeCover";
            this.lb_sizeCover.Size = new System.Drawing.Size(388, 35);
            this.lb_sizeCover.TabIndex = 11;
            this.lb_sizeCover.Click += new System.EventHandler(this.lb_sizeCover_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 701);
            this.Controls.Add(this.lb_size);
            this.Controls.Add(this.lb_speed);
            this.Controls.Add(this.lb_gen);
            this.Controls.Add(this.slider_size);
            this.Controls.Add(this.pb_display);
            this.Controls.Add(this.slider_speed);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_sizeCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.PictureBox pb_display;
        private System.Windows.Forms.TrackBar slider_speed;
        private System.Windows.Forms.Label lb_gen;
        private System.Windows.Forms.TrackBar slider_size;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.Label lb_size;
        private System.Windows.Forms.Label lb_sizeCover;
    }
}

