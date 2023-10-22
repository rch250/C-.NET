using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Add event handlers for each button
            colorButton.Click += new System.EventHandler(colorButton_Click);
            createButton.Click += new System.EventHandler(createButton_Click);
            clearButton.Click += new System.EventHandler(clearButton_Click);
            exitButton.Click += new System.EventHandler(exitButton_Click);

            //Add event handlers for each new button object created by the user
            newButton.Click += new System.EventHandler(newButton_Click);
            newradioButton.Click += new System.EventHandler(newradioButton_Click);
            newTextbox.Click += new System.EventHandler(newTextBox_Click);
            newcheckbox.Click += new System.EventHandler(newcheckbox_Click);
        }

        //We are initializing the controls

        //Initializing GroupBoxes for the form
        GroupBox backGroundColorGroupBox = new GroupBox();
        GroupBox objectGroupBox = new GroupBox();
        GroupBox input1GroupBox = new GroupBox();
        GroupBox input2GroupBox = new GroupBox();
        GroupBox controlGroupBox = new GroupBox();

        // //Initializing Color Dialog Box
        ColorDialog thisColorDialog = new ColorDialog();

        //Initializing the control buttons
        Button colorButton = new Button();
        Button createButton = new Button();
        Button clearButton = new Button();
        Button exitButton = new Button();

        //Initialize new object buttons created by the user
        RadioButton newradioButton  = new RadioButton();
        TextBox     newTextbox      = new TextBox();
        CheckBox    newcheckbox     = new CheckBox();
        Button      newButton       = new Button();

        //Initializing Radio Buttons for new objects to create
        RadioButton radioRadioButton = new RadioButton();
        RadioButton textboxRadioButton = new RadioButton();
        RadioButton checkboxRadioButton = new RadioButton();
        RadioButton buttonRadioButton = new RadioButton();

        //Initializing TextBoxes
        TextBox firstSizeTextBox = new TextBox();
        TextBox nameTextBox = new TextBox();
        TextBox textTextBox = new TextBox();
        TextBox firstLocationTextBox = new TextBox();
        TextBox secondLocationTextBox = new TextBox();
        TextBox secondSizeTextBox = new TextBox();
        //Initializing tool tip
        ToolTip objectToolTip = new ToolTip();
        //Initializing Labels
        Label textLabel = new Label();
        Label sizeLabel = new Label();
        Label locationLabel = new Label();
        Label nameLabel = new Label();

        private void Form1_Load(object sender, EventArgs e)
        {   
            //initialize the form: change the name, form text, set a new icon.
            this.Text = "Object Factory!";//changing form's default Text
            this.Name = "objectFactoryForm";
            this.Icon = new Icon("favicon.ico");//changing forms defult icon
            this.Size = new System.Drawing.Size(600,600);

            //set up the group boxes
            //Setting proper child-parent, location of object groupbox, and size

            objectGroupBox.Parent = this;//this object (group box) belongs to the current form
            objectGroupBox.Location = new System.Drawing.Point(50, 30);//location of the object on the form
            objectGroupBox.Size = new System.Drawing.Size(250, 100);//size of this groupobox on the form
            objectGroupBox.Name = "objectGroupBox";//name of this groupbox
            objectGroupBox.Text = "Select an object";//text ofthis groupbox
            
            //Settings for a size and location group box
            input1GroupBox.Parent = this;//input group box belongs to this form
            input1GroupBox.Location = new System.Drawing.Point(50, 150);
            input1GroupBox.Size = new System.Drawing.Size(250, 80);
            input1GroupBox.Name = "input1GroupBox";
            input1GroupBox.Text = "Select a size and location";

            //Setting define name and text group box
            input2GroupBox.Parent = this;//input group box belongs to this form
            input2GroupBox.Location = new System.Drawing.Point(50, 250);
            input2GroupBox.Size = new System.Drawing.Size(250, 80);
            input2GroupBox.Name = "input2GroupBox";
            input2GroupBox.Text = "Define the name and text";

            //Settings for choose background color group box
            backGroundColorGroupBox.Parent = this;//input group box belongs to this form
            backGroundColorGroupBox.Location = new System.Drawing.Point(50, 350);
            backGroundColorGroupBox.Size = new System.Drawing.Size(250, 80);
            backGroundColorGroupBox.Name = "backGroundColorGroupBox";
            backGroundColorGroupBox.Text = "Choose Favorite Background Color";

            //Settings for control group box
            controlGroupBox.Parent = this;//input group box belongs to this form
            controlGroupBox.Location = new System.Drawing.Point(50, 450);
            controlGroupBox.Size = new System.Drawing.Size(400, 80);
            controlGroupBox.Name = "controlGroupBox";
            controlGroupBox.Text = "Controls";
       

            //Setting Radio Buttons for new objects to create:
            // button, radio button, text box, check box

            //create the buttons for each object to be created:
            //radio button, text box, checkbox, button
            //create radio button to create a radio button
            radioRadioButton.Parent = objectGroupBox;
            radioRadioButton.Location = new System.Drawing.Point(30, 25);
            radioRadioButton.Size = new System.Drawing.Size(100, 30);
            radioRadioButton.Text = "Radio Button";
            objectToolTip.SetToolTip(radioRadioButton, "Will create a radio button");

            //create radio button to create a text box
            textboxRadioButton.Parent = objectGroupBox;
            textboxRadioButton.Location = new System.Drawing.Point(130, 25);
            textboxRadioButton.Size = new System.Drawing.Size(100,30);
            textboxRadioButton.Text = "Text Box";
            objectToolTip.SetToolTip(textboxRadioButton, "Will create a text box");

            //create radio button to create a checkbox
            checkboxRadioButton.Parent = objectGroupBox;
            checkboxRadioButton.Location = new System.Drawing.Point(30, 50);
            checkboxRadioButton.Size = new System.Drawing.Size(100, 30);
            checkboxRadioButton.Text = "Check Box";
            objectToolTip.SetToolTip(checkboxRadioButton, "Will create a check box");

            //create radio button to create a button
            buttonRadioButton.Parent = objectGroupBox;
            buttonRadioButton.Location = new System.Drawing.Point(130, 50);
            buttonRadioButton.Size = new System.Drawing.Size(100, 30);
            buttonRadioButton.Text = "Button";
            objectToolTip.SetToolTip(buttonRadioButton, "Will create a button");

            //Settings for the names of new user created object buttons
            buttonRadioButton.Name = "buttonRadioButton";
            radioRadioButton.Name = "radioRadioButton";
            textboxRadioButton.Name = "textboxRadioButton";
            checkboxRadioButton.Name = "checkboxRadioButton";

            // settings for location and size group box
            // Settings for Location label
            locationLabel.Name = "locationLabel";
            locationLabel.Text = "Location (X,Y)";
            locationLabel.Parent = input1GroupBox;
            locationLabel.Location = new System.Drawing.Point(20, 30);
            locationLabel.Size = new System.Drawing.Size(100, 20);

            //Settings for location TextBox
            firstLocationTextBox.Parent = input1GroupBox;
            firstLocationTextBox.TabIndex= 0;
            firstLocationTextBox.Location = new System.Drawing.Point(120, 30);
            firstLocationTextBox.Size = new System.Drawing.Size(50, 20);
            firstLocationTextBox.Name = "locationTextBox";
            secondLocationTextBox.Parent = input1GroupBox;
            firstLocationTextBox.TabIndex = 1;
            secondLocationTextBox.Location = new System.Drawing.Point(180, 30);
            secondLocationTextBox.Size = new System.Drawing.Size(50, 20);
            secondLocationTextBox.Name = "locationYTextBox";

            //Settings for size text box
            sizeLabel.Parent = input1GroupBox;
            sizeLabel.Location = new System.Drawing.Point(20, 60);
            sizeLabel.Size = new System.Drawing.Size(100, 20);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Text = "Size (W,H)";
            //Setting Size TextBox
            firstSizeTextBox.Parent = input1GroupBox;
            firstSizeTextBox.TabIndex = 2;
            firstSizeTextBox.Location = new System.Drawing.Point(120, 60);
            firstSizeTextBox.Size = new System.Drawing.Size(50, 20);
            firstSizeTextBox.Name = "sizeTextBox";

            secondSizeTextBox.Parent = input1GroupBox;
            secondSizeTextBox.TabIndex = 3;
            secondSizeTextBox.Location = new System.Drawing.Point(180, 60);
            secondSizeTextBox.Size = new System.Drawing.Size(50, 20);
            secondSizeTextBox.Name = "sizeYTextBox";

            // settings for name and text group box
            //Settings for Name Label
            nameLabel.Parent = input2GroupBox;
            nameLabel.Location = new System.Drawing.Point(20, 30);
            nameLabel.Size = new System.Drawing.Size(100, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Text = "Enter Name";

            //Settings for Name TextBox
            nameTextBox.Parent = input2GroupBox;
            nameTextBox.TabIndex = 4;
            nameTextBox.Location = new System.Drawing.Point(120, 30);
            nameTextBox.Size = new System.Drawing.Size(100, 200);
            nameTextBox.Name = "nameTextBox";

            //settings for Text textbox labels        
            textLabel.Parent = input2GroupBox;
            textLabel.Location = new System.Drawing.Point(20, 60);
            textLabel.Size = new System.Drawing.Size(100, 20);
            textLabel.Name = "textTextBox";
            textLabel.Text = "Enter Text";
            //Settings for Text TextBox
            textTextBox.Parent = input2GroupBox;
            textTextBox.TabIndex = 5;
            textTextBox.Location = new System.Drawing.Point(120, 60);
            textTextBox.Size = new System.Drawing.Size(100, 20);
            textTextBox.Name = "textTextBox";

            //settings for background color group box
            //settings for background colorButton
            backGroundColorGroupBox.Controls.Add(colorButton);
            colorButton.Location = new Point(50, 30);
            colorButton.TabIndex= 6;
            colorButton.Size = new Size(100, 30);
            colorButton.Name = "colorButton";
            colorButton.Text = "&Choose Color";
            objectToolTip.SetToolTip(colorButton, "Choose your Favorite Color");

            //settings for control group box: Create, Clear, Exit

            //Create button
            createButton.Parent = controlGroupBox;
            createButton.Location = new System.Drawing.Point(30,30);
            createButton.TabIndex = 7;
            createButton.Size = new System.Drawing.Size(100, 30);
            createButton.Name = "createButton";
            createButton.Text = "&Create";
            //Assigning tool tip to create button
            objectToolTip.SetToolTip(createButton, "Press to create objects");

            //Clear button
            clearButton.Parent = controlGroupBox;
            clearButton.Location = new System.Drawing.Point(150, 30);
            clearButton.TabIndex = 8;
            clearButton.Size = new System.Drawing.Size(100, 30);
            clearButton.Name = "clearButton";
            clearButton.Text = "Clear";
            //Assigning tool tip to clear button
            objectToolTip.SetToolTip(clearButton, "Clear the form");


            //exit button
            exitButton.Parent = controlGroupBox;
            exitButton.Location = new System.Drawing.Point(270, 30);
            exitButton.TabIndex = 9;
            exitButton.Size = new System.Drawing.Size(100, 30);
            exitButton.Name = "exitButton";
            exitButton.Text = "Exit";
            //Assigning tool tip to exit button
            objectToolTip.SetToolTip(exitButton, "Exit the program");

        }

     
        // events
        // create events for buttons


        //creating event for new object buttons
        //creating event for new button
        private void newButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You  Clicked me!");
        }
        //creating event for new radio button
        private void newradioButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You  Clicked me!");
        }
        //creating event for new text box
        private void newTextBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You  Clicked me!");
        }
        //creating event for new checkbox
        private void newcheckbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You  Clicked me!");
        }
        // create event for color button
        private void colorButton_Click(object sender, EventArgs e)
        {
            //change the groupbox background to user's choice
            if (thisColorDialog.ShowDialog() == DialogResult.OK)
            {
                backGroundColorGroupBox.BackColor = thisColorDialog.Color;
            }
        }

        // create event for clear button
        private void clearButton_Click(object sender, EventArgs e)
        { // clear the form
        
            // clear the radio buttons
            radioRadioButton.Checked= false;
            textboxRadioButton.Checked = false;
            checkboxRadioButton.Checked = false;
            buttonRadioButton.Checked = false;

            //clear the text boxes
            firstLocationTextBox.Text = string.Empty;
            secondLocationTextBox.Text = string.Empty;
            firstSizeTextBox.Text= string.Empty; 
            secondSizeTextBox.Text= string.Empty;
            nameTextBox.Text = string.Empty;
            textTextBox.Text= string.Empty;

            // clear background color
           backGroundColorGroupBox.BackColor = default;
        }

        // create event for exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hope you enjoyed using this program!", "Exit");
            this.Close();
        }


        // create event for create button
        // create event for create button
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRadioButton.Checked)
                {
                    //publishes user input to a new form
                    Form newForm = new Form();//creating an instance of new form that will be created dynamically
                    newForm.Icon = new Icon("favicon.ico");//changing forms defult icon
                    newButton.Name = nameTextBox.Text;
                    newButton.Text = textTextBox.Text;
                    newButton.Parent = newForm;
                    newButton.Location = new System.Drawing.Point((Int32.Parse(firstLocationTextBox.Text)), Int32.Parse(secondLocationTextBox.Text));
                    newButton.Size = new System.Drawing.Size((Int32.Parse(firstSizeTextBox.Text)), Int32.Parse(secondSizeTextBox.Text));
                    newButton.BackColor = backGroundColorGroupBox.BackColor;
                    newForm.ShowDialog();
                }
                else if (radioRadioButton.Checked)
                {
                    //publishes user input to a new form
                    Form newForm = new Form();//creating an instance of new form that will be created dynamically
                    newForm.Icon = new Icon("favicon.ico");//changing forms defult icon
                    newradioButton.Name = nameTextBox.Text;
                    newradioButton.Text = textTextBox.Text;
                    newradioButton.Parent = newForm;
                    newradioButton.Location = new System.Drawing.Point((Int32.Parse(firstLocationTextBox.Text)), Int32.Parse(secondLocationTextBox.Text));
                    newradioButton.Size = new System.Drawing.Size((Int32.Parse(firstSizeTextBox.Text)), Int32.Parse(secondSizeTextBox.Text));
                    newradioButton.BackColor = backGroundColorGroupBox.BackColor;
                    newForm.ShowDialog();
                }
                else if (textboxRadioButton.Checked)
                {
                    //publishes user input to a new form
                    Form newForm = new Form();//creating an instance of new form that will be created dynamically
                    newForm.Icon = new Icon("favicon.ico");//changing forms defult icon
                    newTextbox.Name = nameTextBox.Text;
                    newTextbox.Text = textTextBox.Text;
                    newTextbox.Parent = newForm;
                    newTextbox.Location = new System.Drawing.Point((Int32.Parse(firstLocationTextBox.Text)), Int32.Parse(secondLocationTextBox.Text));
                    newTextbox.Size = new System.Drawing.Size((Int32.Parse(firstSizeTextBox.Text)), Int32.Parse(secondSizeTextBox.Text));
                    newTextbox.BackColor = backGroundColorGroupBox.BackColor;
                    newForm.ShowDialog();
                }
                else if (checkboxRadioButton.Checked)
                {
                    //publishes user input to a new form
                    Form newForm = new Form();//creating an instance of new form that will be created dynamically
                    newForm.Icon = new Icon("favicon.ico");//changing forms defult icon
                    newcheckbox.Name = nameTextBox.Text;
                    newcheckbox.Text = textTextBox.Text;
                    newcheckbox.Parent = newForm;
                    newcheckbox.Location = new System.Drawing.Point((Int32.Parse(firstLocationTextBox.Text)), Int32.Parse(secondLocationTextBox.Text));
                    newcheckbox.Size = new System.Drawing.Size((Int32.Parse(firstSizeTextBox.Text)), Int32.Parse(secondSizeTextBox.Text));
                    newcheckbox.BackColor = backGroundColorGroupBox.BackColor;
                    newForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Did you check all required areas? ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Could not process your request. Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
