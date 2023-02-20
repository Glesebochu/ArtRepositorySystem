using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using DrakeUI.Framework;

namespace ArtRepositorySystem
{
    internal class FeedBackForm : UserControl
    {
        private DrakeUITitlePanel panel;
        private List<DrakeUITitlePanel> listOfGeneratedPanels;
        private DrakeUITextBox answerBox = new DrakeUITextBox();
        private MaterialFlatButton submit = new MaterialFlatButton();
        private List<string> listOfQuestions = Questions.feedBackQuestions;
        private List<MaterialRadioButton> choice1 = new List<MaterialRadioButton>() { new MaterialRadioButton(), new MaterialRadioButton(), new MaterialRadioButton(), new MaterialRadioButton()};
        private List<MaterialRadioButton> choice2 = new List<MaterialRadioButton>() { new MaterialRadioButton(), new MaterialRadioButton()};
        private List<MaterialRadioButton> choice3 = new List<MaterialRadioButton>() { new MaterialRadioButton(), new MaterialRadioButton()};
        private List<MaterialRadioButton> choice4 = new List<MaterialRadioButton>() { new MaterialRadioButton(), new MaterialRadioButton()};


        public FeedBackForm()
        {
            // call the InitializeComponent Method
            InitializeComponent();

            // generate a list of panal based on the number of question you have
            listOfGeneratedPanels = this.generatePanels(listOfQuestions.Count);

            // populate the list of generated panels with some data
            this.populatePanels();

            // pass the populated panels to a method to populate the parentContol ( parentControl -> is the place where the populated panels reside ).
            this.populateParentControl(listOfGeneratedPanels);



        }

        // Create a method that generate a panels
        private List<DrakeUITitlePanel> generatePanels(int numberOfPanels)
        {
            // create a local variavble to store a list of generated panels.
            List <DrakeUITitlePanel> result = new List<DrakeUITitlePanel>();

            // loop numberOfPanels times and create the panels
            for (int i = 0; i < numberOfPanels; i++)
            {
                panel = new DrakeUITitlePanel();
                panel.Location = new Point((this.Width/2 - 30), 20 + i * 220);
                panel.Width = 600;
                panel.Height = 200;
                panel.Radius = 30;
                panel.TitleColor = Color.Gray;
                panel.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                panel.FillColor = Color.LightGray;
                result.Add(panel);
            }

            // return a list that holds (contains) the generated panels.
            return result;
        }


        private void populatePanels() {
            for (int index = 0; index < this.listOfGeneratedPanels.Count; index++)
            {
                listOfGeneratedPanels[index].Text = listOfQuestions[index];
                listOfGeneratedPanels[index].TextAlign = HorizontalAlignment.Left;

                if (index == 0)
                {
                    // Button1
                    choice1[0].Visible = true;
                    choice1[0].Text = "Yes";
                    choice1[0].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice1[0].Location = new Point(30, 60);
                    choice1[0].BackColor = Color.LightGray;

                    // Button2
                    choice1[1].Visible = true;
                    choice1[1].Text = "No";
                    choice1[1].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice1[1].Location = new Point(30, 90);
                    choice1[1].BackColor = Color.LightGray;

                    // Button3
                    choice1[2].Visible = true;
                    choice1[2].Text = "Sometimes";
                    choice1[2].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice1[2].Location = new Point(210, 60);
                    choice1[2].BackColor = Color.LightGray;

                    // Button4
                    choice1[3].Visible = true;
                    choice1[3].Text = "It depends";
                    choice1[3].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice1[3].Location = new Point(210, 90);
                    choice1[3].BackColor = Color.LightGray;


                    // add buttons to the pannel
                    this.addMaterialRadioButtonsToPanel(listOfGeneratedPanels[index],choice1);

                }

                else if (index == 1)
                {
                    // Button1
                    choice2[0].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice2[0].Text = "Yes";
                    choice2[0].Location = new Point(30, 60);
                    choice2[0].BackColor = Color.LightGray;

                    // Button2
                    choice2[1].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice2[1].Text = "No";
                    choice2[1].Location = new Point(30, 90);
                    choice2[1].BackColor = Color.LightGray;

                    // add buttons to the pannel
                    this.addMaterialRadioButtonsToPanel(listOfGeneratedPanels[index], choice2);

                }
                else if (index == 2)
                {
                    // Button1
                    choice3[0].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice3[0].Text = "Yes";
                    choice3[0].Location = new Point(30, 60);
                    choice3[0].BackColor = Color.LightGray;

                    // Button2
                    choice3[1].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice3[1].Text = "No";
                    choice3[1].Location = new Point(30, 90);
                    choice3[1].BackColor = Color.LightGray;

                    // add buttons to the pannel
                    this.addMaterialRadioButtonsToPanel(listOfGeneratedPanels[index], choice3);

                }
                else if (index == 3)
                {
                    // Button1
                    choice4[0].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice4[0].Text = "Yes";
                    choice4[0].Location = new Point(30, 60);
                    choice4[0].BackColor = Color.LightGray;

                    // Button2
                    choice4[1].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    choice4[1].Text = "No";
                    choice4[1].Location = new Point(30, 90);
                    choice4[1].BackColor = Color.Red;

                    // add buttons to the pannel
                    this.addMaterialRadioButtonsToPanel(listOfGeneratedPanels[index], choice4);

                }
                else if(index == 4)
                {
                    answerBox.BackColor = Color.White;
                    answerBox.ForeColor = Color.FromArgb(255, 45, 45, 48);
                    answerBox.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    answerBox.Radius = 20;
                    answerBox.Multiline = true;
                    answerBox.Size = new Size(280, 60);
                    answerBox.Location = new Point(10, 70);
                    answerBox.FillColor = Color.FromArgb(225, 245, 254);
                    answerBox.FillColor = Color.LightGray;
                    answerBox.RectColor = Color.Gray;
                    listOfGeneratedPanels[index].Controls.Add(answerBox);
                }
            }

            // add the submit button to the control and make it attached to the bottom of the control.
            submit.Text = "Submit";
            submit.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            submit.FlatStyle = FlatStyle.Flat;
            submit.FlatAppearance.BorderSize = 0;
            submit.Dock = DockStyle.Bottom;
            submit.Click += Submit_OnClick;
            this.Controls.Add(submit);
        }

        private void Submit_OnClick(object? sender, EventArgs e)
        {
            Feedback fb = new Feedback();
            List<List<MaterialRadioButton>> choices = new List<List<MaterialRadioButton>> { choice1,choice2,choice3,choice4 };
            for (int index=0; index < listOfGeneratedPanels.Count; index++)
            {
                QnA qna = new QnA();
                if(index != 4)
                {
                    foreach(MaterialRadioButton button in choices[index])
                    {
                        if(button.Checked)
                        {
                            qna.Prompt = listOfGeneratedPanels[index].Text;
                            qna.Answer = button.Text;
                            if(index == 0)
                            {
                                qna.Type = QuestionType.MultiSelect;
                            }
                            else if(index == 4)
                            {
                                qna.Type = QuestionType.ShortAnswer;
                            }
                            else
                            {
                                qna.Type = QuestionType.YesOrNo;
                            }

                            fb.Questions.Add(qna);
                        }
                    }
                }
                else
                {
                    if(answerBox.Text != "")
                    {
                        qna.Prompt = listOfGeneratedPanels[index].Text;
                        qna.Type = QuestionType.ShortAnswer;
                        qna.Answer = answerBox.Text;
                        fb.Questions.Add(qna);
                    }

                }
                
            }

            // call the feedback's saveFeedBack method to save the user filled data to the database.
            fb.saveFeedBack();
        }

        // Create a method the populate the parentControl with the generated list<Panels>.
        private void populateParentControl(List<DrakeUITitlePanel> panels)
        {
            foreach(DrakeUITitlePanel panel in panels)
            {
                this.Controls.Add(panel);
            }
        }


        private void addMaterialRadioButtonsToPanel(DrakeUITitlePanel panel, List<MaterialRadioButton> choice)
        {
            for (int index=0; index<choice.Count; index++)
            {
                panel.Controls.Add(choice[index]);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "FeedBackForm";
            AutoScroll = true;
            this.ResumeLayout(false);


        }
    }
}




