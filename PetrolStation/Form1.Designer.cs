using System;
using System.Windows.Forms;

namespace PetrolStation
{
    partial class PetrolStation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pump1 = new System.Windows.Forms.Label();
            this.pump2 = new System.Windows.Forms.Label();
            this.pump3 = new System.Windows.Forms.Label();
            this.pump4 = new System.Windows.Forms.Label();
            this.pump5 = new System.Windows.Forms.Label();
            this.pump6 = new System.Windows.Forms.Label();
            this.pump9 = new System.Windows.Forms.Label();
            this.pump8 = new System.Windows.Forms.Label();
            this.pump7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pump1Timer = new System.Windows.Forms.Timer(this.components);
            this.pump2Timer = new System.Windows.Forms.Timer(this.components);
            this.pumpTimer3 = new System.Windows.Forms.Timer(this.components);
            this.pumpTimer4 = new System.Windows.Forms.Timer(this.components);
            this.pumpTimer5 = new System.Windows.Forms.Timer(this.components);
            this.pumpTimer6 = new System.Windows.Forms.Timer(this.components);
            this.pumpTimer7 = new System.Windows.Forms.Timer(this.components);
            this.pumpTimer8 = new System.Windows.Forms.Timer(this.components);
            this.pumpTimer9 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.counterLitres = new System.Windows.Forms.Label();
            this.counterGains = new System.Windows.Forms.Label();
            this.counterComission = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.counterDiesel = new System.Windows.Forms.Label();
            this.counterLPG = new System.Windows.Forms.Label();
            this.counterUnleaded = new System.Windows.Forms.Label();
            this.vehiclesServiced = new System.Windows.Forms.Label();
            this.vehicleWaitTimer = new System.Windows.Forms.Timer(this.components);
            this.vehiclesWaiting = new System.Windows.Forms.Label();
            this.vehicleLeft = new System.Windows.Forms.Label();
            this.transactionButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CountersDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pump 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pump 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pump 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pump 6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pump 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pump 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pump 9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pump 8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Pump 7";
            // 
            // pump1
            // 
            this.pump1.AutoSize = true;
            this.pump1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump1.Location = new System.Drawing.Point(86, 155);
            this.pump1.Name = "pump1";
            this.pump1.Size = new System.Drawing.Size(40, 21);
            this.pump1.TabIndex = 9;
            this.pump1.Text = "Free";
            // 
            // pump2
            // 
            this.pump2.AutoSize = true;
            this.pump2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump2.Location = new System.Drawing.Point(202, 155);
            this.pump2.Name = "pump2";
            this.pump2.Size = new System.Drawing.Size(40, 21);
            this.pump2.TabIndex = 10;
            this.pump2.Text = "Free";
            // 
            // pump3
            // 
            this.pump3.AutoSize = true;
            this.pump3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump3.Location = new System.Drawing.Point(322, 155);
            this.pump3.Name = "pump3";
            this.pump3.Size = new System.Drawing.Size(40, 21);
            this.pump3.TabIndex = 11;
            this.pump3.Text = "Free";
            // 
            // pump4
            // 
            this.pump4.AutoSize = true;
            this.pump4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump4.Location = new System.Drawing.Point(86, 260);
            this.pump4.Name = "pump4";
            this.pump4.Size = new System.Drawing.Size(40, 21);
            this.pump4.TabIndex = 12;
            this.pump4.Text = "Free";
            // 
            // pump5
            // 
            this.pump5.AutoSize = true;
            this.pump5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump5.Location = new System.Drawing.Point(202, 260);
            this.pump5.Name = "pump5";
            this.pump5.Size = new System.Drawing.Size(40, 21);
            this.pump5.TabIndex = 13;
            this.pump5.Text = "Free";
            // 
            // pump6
            // 
            this.pump6.AutoSize = true;
            this.pump6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump6.Location = new System.Drawing.Point(322, 260);
            this.pump6.Name = "pump6";
            this.pump6.Size = new System.Drawing.Size(40, 21);
            this.pump6.TabIndex = 14;
            this.pump6.Text = "Free";
            // 
            // pump9
            // 
            this.pump9.AutoSize = true;
            this.pump9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump9.Location = new System.Drawing.Point(322, 364);
            this.pump9.Name = "pump9";
            this.pump9.Size = new System.Drawing.Size(40, 21);
            this.pump9.TabIndex = 17;
            this.pump9.Text = "Free";
            // 
            // pump8
            // 
            this.pump8.AutoSize = true;
            this.pump8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump8.Location = new System.Drawing.Point(202, 364);
            this.pump8.Name = "pump8";
            this.pump8.Size = new System.Drawing.Size(40, 21);
            this.pump8.TabIndex = 16;
            this.pump8.Text = "Free";
            // 
            // pump7
            // 
            this.pump7.AutoSize = true;
            this.pump7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump7.Location = new System.Drawing.Point(86, 364);
            this.pump7.Name = "pump7";
            this.pump7.Size = new System.Drawing.Size(40, 21);
            this.pump7.TabIndex = 15;
            this.pump7.Text = "Free";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1578;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pump1Timer
            // 
            this.pump1Timer.Tick += new System.EventHandler(this.pump1Timer_Tick);
            // 
            // pump2Timer
            // 
            this.pump2Timer.Tick += new System.EventHandler(this.pump2Timer_Tick);
            // 
            // pumpTimer3
            // 
            this.pumpTimer3.Tick += new System.EventHandler(this.pumpTimer3_Tick);
            // 
            // pumpTimer4
            // 
            this.pumpTimer4.Tick += new System.EventHandler(this.pumpTimer4_Tick);
            // 
            // pumpTimer5
            // 
            this.pumpTimer5.Tick += new System.EventHandler(this.pumpTimer5_Tick);
            // 
            // pumpTimer6
            // 
            this.pumpTimer6.Tick += new System.EventHandler(this.pumpTimer6_Tick);
            // 
            // pumpTimer7
            // 
            this.pumpTimer7.Tick += new System.EventHandler(this.pumpTimer7_Tick);
            // 
            // pumpTimer8
            // 
            this.pumpTimer8.Tick += new System.EventHandler(this.pumpTimer8_Tick);
            // 
            // pumpTimer9
            // 
            this.pumpTimer9.Tick += new System.EventHandler(this.pumpTimer9_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(462, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Litres Dispensed = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(462, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total Gains =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(461, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 23);
            this.label12.TabIndex = 30;
            this.label12.Text = "Comission =";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(462, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 23);
            this.label13.TabIndex = 31;
            this.label13.Text = "Vehicles Serviced =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(462, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "Vehicles that left =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(461, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 23);
            this.label15.TabIndex = 33;
            this.label15.Text = "Vehicles waiting =";
            // 
            // counterLitres
            // 
            this.counterLitres.AutoSize = true;
            this.counterLitres.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLitres.Location = new System.Drawing.Point(649, 70);
            this.counterLitres.Name = "counterLitres";
            this.counterLitres.Size = new System.Drawing.Size(20, 23);
            this.counterLitres.TabIndex = 34;
            this.counterLitres.Text = "0";
            // 
            // counterGains
            // 
            this.counterGains.AutoSize = true;
            this.counterGains.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterGains.Location = new System.Drawing.Point(610, 223);
            this.counterGains.Name = "counterGains";
            this.counterGains.Size = new System.Drawing.Size(20, 23);
            this.counterGains.TabIndex = 35;
            this.counterGains.Text = "0";
            // 
            // counterComission
            // 
            this.counterComission.AutoSize = true;
            this.counterComission.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterComission.Location = new System.Drawing.Point(610, 260);
            this.counterComission.Name = "counterComission";
            this.counterComission.Size = new System.Drawing.Size(20, 23);
            this.counterComission.TabIndex = 36;
            this.counterComission.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(463, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 23);
            this.label16.TabIndex = 37;
            this.label16.Text = "Diesel Dispensed = ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(463, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 23);
            this.label17.TabIndex = 38;
            this.label17.Text = "LPG Dispensed = ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(463, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 23);
            this.label18.TabIndex = 39;
            this.label18.Text = "Unleaded Dispensed = ";
            // 
            // counterDiesel
            // 
            this.counterDiesel.AutoSize = true;
            this.counterDiesel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterDiesel.Location = new System.Drawing.Point(649, 105);
            this.counterDiesel.Name = "counterDiesel";
            this.counterDiesel.Size = new System.Drawing.Size(20, 23);
            this.counterDiesel.TabIndex = 40;
            this.counterDiesel.Text = "0";
            // 
            // counterLPG
            // 
            this.counterLPG.AutoSize = true;
            this.counterLPG.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLPG.Location = new System.Drawing.Point(649, 144);
            this.counterLPG.Name = "counterLPG";
            this.counterLPG.Size = new System.Drawing.Size(20, 23);
            this.counterLPG.TabIndex = 41;
            this.counterLPG.Text = "0";
            // 
            // counterUnleaded
            // 
            this.counterUnleaded.AutoSize = true;
            this.counterUnleaded.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterUnleaded.Location = new System.Drawing.Point(658, 178);
            this.counterUnleaded.Name = "counterUnleaded";
            this.counterUnleaded.Size = new System.Drawing.Size(20, 23);
            this.counterUnleaded.TabIndex = 42;
            this.counterUnleaded.Text = "0";
            // 
            // vehiclesServiced
            // 
            this.vehiclesServiced.AutoSize = true;
            this.vehiclesServiced.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesServiced.Location = new System.Drawing.Point(627, 302);
            this.vehiclesServiced.Name = "vehiclesServiced";
            this.vehiclesServiced.Size = new System.Drawing.Size(20, 23);
            this.vehiclesServiced.TabIndex = 43;
            this.vehiclesServiced.Text = "0";
            // 
            // vehicleWaitTimer
            // 
            this.vehicleWaitTimer.Interval = 1330;
            this.vehicleWaitTimer.Tick += new System.EventHandler(this.vehicleWaitTimer_Tick);
            // 
            // vehiclesWaiting
            // 
            this.vehiclesWaiting.AutoSize = true;
            this.vehiclesWaiting.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesWaiting.Location = new System.Drawing.Point(610, 378);
            this.vehiclesWaiting.Name = "vehiclesWaiting";
            this.vehiclesWaiting.Size = new System.Drawing.Size(20, 23);
            this.vehiclesWaiting.TabIndex = 44;
            this.vehiclesWaiting.Text = "0";
            // 
            // vehicleLeft
            // 
            this.vehicleLeft.AutoSize = true;
            this.vehicleLeft.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLeft.Location = new System.Drawing.Point(627, 341);
            this.vehicleLeft.Name = "vehicleLeft";
            this.vehicleLeft.Size = new System.Drawing.Size(20, 23);
            this.vehicleLeft.TabIndex = 45;
            this.vehicleLeft.Text = "0";
            // 
            // transactionButton
            // 
            this.transactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionButton.Location = new System.Drawing.Point(481, 438);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(197, 44);
            this.transactionButton.TabIndex = 46;
            this.transactionButton.Text = "List Transactions";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.CausesValidation = false;
            this.label19.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(35, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(327, 29);
            this.label19.TabIndex = 47;
            this.label19.Text = "Petrol Somewhat Unlimited Ltd";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::PetrolStation.Properties.Resources.Anglia_Ruskin_University_logo_svg;
            this.pictureBox11.Location = new System.Drawing.Point(12, 407);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(302, 96);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 49;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PetrolStation.Properties.Resources.fuelincon;
            this.pictureBox10.InitialImage = global::PetrolStation.Properties.Resources.fuelincon;
            this.pictureBox10.Location = new System.Drawing.Point(379, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(66, 64);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(287, 351);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 50);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(168, 351);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(62, 351);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(287, 244);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(168, 244);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(62, 244);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(287, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(168, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(62, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // CountersDisplay
            // 
            this.CountersDisplay.AutoSize = true;
            this.CountersDisplay.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountersDisplay.Location = new System.Drawing.Point(462, 26);
            this.CountersDisplay.Name = "CountersDisplay";
            this.CountersDisplay.Size = new System.Drawing.Size(102, 29);
            this.CountersDisplay.TabIndex = 50;
            this.CountersDisplay.Text = "Counters";
            // 
            // PetrolStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 515);
            this.Controls.Add(this.CountersDisplay);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.vehicleLeft);
            this.Controls.Add(this.vehiclesWaiting);
            this.Controls.Add(this.vehiclesServiced);
            this.Controls.Add(this.counterUnleaded);
            this.Controls.Add(this.counterLPG);
            this.Controls.Add(this.counterDiesel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.counterComission);
            this.Controls.Add(this.counterGains);
            this.Controls.Add(this.counterLitres);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pump9);
            this.Controls.Add(this.pump8);
            this.Controls.Add(this.pump7);
            this.Controls.Add(this.pump6);
            this.Controls.Add(this.pump5);
            this.Controls.Add(this.pump4);
            this.Controls.Add(this.pump3);
            this.Controls.Add(this.pump2);
            this.Controls.Add(this.pump1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PetrolStation";
            this.Text = "Petrol Station";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pump1;
        private System.Windows.Forms.Label pump2;
        private System.Windows.Forms.Label pump3;
        private System.Windows.Forms.Label pump4;
        private System.Windows.Forms.Label pump5;
        private System.Windows.Forms.Label pump6;
        private System.Windows.Forms.Label pump9;
        private System.Windows.Forms.Label pump8;
        private System.Windows.Forms.Label pump7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Timer timer1;
        private Timer pump1Timer;
        private Timer pump2Timer;
        private Timer pumpTimer3;
        private Timer pumpTimer4;
        private Timer pumpTimer5;
        private Timer pumpTimer6;
        private Timer pumpTimer7;
        private Timer pumpTimer8;
        private Timer pumpTimer9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label counterLitres;
        private Label counterGains;
        private Label counterComission;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label counterDiesel;
        private Label counterLPG;
        private Label counterUnleaded;
        private Label vehiclesServiced;
        private Timer vehicleWaitTimer;
        private Label vehiclesWaiting;
        private Label vehicleLeft;
        private Button transactionButton;
        private Label label19;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Label CountersDisplay;
    }
}

