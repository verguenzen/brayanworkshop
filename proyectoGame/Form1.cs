using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoGame
{
    public partial class Form1 : Form
    {
        int[] trials = new int[20];
        
        int[] trialsColors = new int[20];
        
        int currentTrial = 0;
        
        bool waitingResp = false;
        
        bool isMatch = false;
        
        bool isMatchColor = false;
        
        bool inputTriggered = false;
        
        bool inputTriggeredColor = false;
        
        Timer timerBetween, timerResponse;

        int aciertos = 0, errores = 0, neutral = 0, aciertosColor = 0, erroresColor = 0, neutralColor = 0;

        public Form1()
        {
            InitializeComponent();

            initTrials(trials, 1, 4);

            initTrials(trialsColors, 1, 4);


            initializeTimers();

            declareKeydowns(this.button1);
            declareKeydowns(this.button2);
            declareKeydowns(this.button3);
            declareKeydowns(this.button4);

            timerBetween.Start();
        }
        
        private void restarBooleans()
        {
            isMatch = false;
            waitingResp = false;
            inputTriggered = false;

            isMatchColor = false;

            inputTriggeredColor = false;
        }
        
        private void restarPositions()
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;

            lblTrial.Text = (currentTrial + 1).ToString();

            lblPositionMatch.ForeColor = Color.Black;
            lblColorMatch.ForeColor = Color.Black;
        }
        
        private void setPosition(int _currentTrial, int[] _trials, int[] _trialsColors)
        {
            int positionTrial = _trials[_currentTrial];

            int positionTrialColor = _trialsColors[_currentTrial];

            switch (positionTrial)
            {
                case 1:
                    setterColorTrial(button1, positionTrialColor);
                    break;
                case 2:
                    setterColorTrial(button2, positionTrialColor);
                    break;
                case 3:
                    setterColorTrial(button3, positionTrialColor);
                    break;
                case 4:
                    setterColorTrial(button4, positionTrialColor);
                    break;
            }
        }

        private void setterColorTrial(Button _btn, int _positionTrialColor)
        {
            switch (_positionTrialColor)
            {
                case 1:
                    _btn.BackColor = Color.Red;
                    break;
                case 2:
                    _btn.BackColor = Color.Green;
                    break;
                case 3:
                    _btn.BackColor = Color.Blue;
                    break;
                case 4:
                    _btn.BackColor = Color.Yellow;
                    break;
            }
        }
        
        private void updateScore()
        {
            lblAciertos.Text = aciertos.ToString();
            lblNeutral.Text = neutral.ToString();
            lblFallos.Text = errores.ToString();

            lblAciertoColor.Text = aciertosColor.ToString();
            lblNeutralColor.Text = neutralColor.ToString();
            lblErrorColor.Text = erroresColor.ToString();

        }
        
        public void declareKeydowns(Button _buton)
        {
            _buton.KeyDown += new KeyEventHandler(this.allbutons_KeyDowns);
        }
        
        private void allbutons_KeyDowns(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A && waitingResp == true && inputTriggered == false)
            {
                inputTriggered = true;

                isMatch = true;

                if (currentTrial <= 19)
                {
                    printValidateTrial();
                }
            }

            if (e.KeyCode == Keys.L && waitingResp == true && inputTriggeredColor == false)
            {
                inputTriggeredColor = true;

                isMatchColor = true;

                if (currentTrial <= 19)
                {
                    printValidateColorTrial();
                }
            }
        }

        public static void initTrials(int[] _trials, int _range1, int _range2)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                _trials[i] = rnd.Next(_range1, _range2);
            }
        }

        public void trialsStatics(int[] _trials)
        {
            _trials[0] = 2;
            _trials[1] = 2;
            _trials[2] = 1;
            _trials[3] = 2;
            _trials[4] = 3;
            _trials[5] = 2;
            _trials[6] = 3;
            _trials[7] = 3;
            _trials[8] = 1;
            _trials[9] = 2;
            _trials[10] = 1;
            _trials[11] = 2;
            _trials[12] = 1;
            _trials[13] = 4;
            _trials[14] = 1;
            _trials[15] = 2;
            _trials[16] = 4;
            _trials[17] = 2;
            _trials[18] = 4;
            _trials[19] = 4;

        }
        
        public void trialsColorStatics(int[] _trialsColors)
        {
            _trialsColors[0] = 2;
            _trialsColors[1] = 2;
            _trialsColors[2] = 1;
            _trialsColors[3] = 2;
            _trialsColors[4] = 3;
            _trialsColors[5] = 2;
            _trialsColors[6] = 3;
            _trialsColors[7] = 3;
            _trialsColors[8] = 1;
            _trialsColors[9] = 2;
            _trialsColors[10] = 1;
            _trialsColors[11] = 2;
            _trialsColors[12] = 1;
            _trialsColors[13] = 4;
            _trialsColors[14] = 1;
            _trialsColors[15] = 2;
            _trialsColors[16] = 4;
            _trialsColors[17] = 2;
            _trialsColors[18] = 4;
            _trialsColors[19] = 4;
        }
        
        private void initializeTimers()
        {
            timerBetween = new Timer();
            timerResponse = new Timer();

            timerBetween.Interval = 1000;
            timerBetween.Tick += timerBetween_Tick;

            timerResponse.Interval = 1000;
            timerResponse.Tick += timerResponse_Tick;

        }
        
        private void timerBetween_Tick(object sender, EventArgs e)
        {
            timerBetween.Stop();

            waitingResp = true;

            timerResponse.Start();

            if (currentTrial >= 0 && currentTrial <= 19)
            {
                setPosition(currentTrial, trials, trialsColors);
            }
        }
        
        private void timerResponse_Tick(object sender, EventArgs e)
        {
            
            if (currentTrial <= 19)
            {
                validateTrial();

                validateTrialColor();

                timerResponse.Stop();

                restarPositions();

                updateScore();

                restarBooleans();

                timerBetween.Start();

                currentTrial++;
            }

        }
        
        private void validateTrial()
        {
            if (isMatch == true)
            {
                if (solveCurrentTrial() == true)
                {
                    aciertos++;
                }
                else
                {
                    errores++;
                }
            }
            else
            {
                if (solveCurrentTrial() == true)
                {
                    errores++;
                }
                else
                {
                    neutral++;
                }
            }
        }
        
        private void validateTrialColor()
        {
            if (isMatchColor == true)
            {
                if (solveCurrenTrialColor() == true)
                {
                    aciertosColor++;
                }
                else
                {
                    erroresColor++;
                }
            }
            else
            {
                if (solveCurrenTrialColor() == true)
                {
                    erroresColor++;
                }
                else
                {
                    neutralColor++;
                }
            }
        }
        
        private void printValidateTrial()
        {
            if (isMatch == true)
            {
                if (solveCurrentTrial() == true)
                {
                    lblPositionMatch.ForeColor = Color.Green;
                }
                else
                {
                    
                    lblPositionMatch.ForeColor = Color.Red;
                }
            }
            else
            {
                if (solveCurrentTrial() == true)
                {
                    lblPositionMatch.ForeColor = Color.Red;
                }
                else
                {
                    lblPositionMatch.ForeColor = Color.Black;
                }
            }
        }
        
        private void printValidateColorTrial()
        {
            if (isMatchColor == true)
            {
                if (solveCurrenTrialColor() == true)
                {
                    lblColorMatch.ForeColor = Color.Green;
                }
                else
                {
                    lblColorMatch.ForeColor = Color.Red;
                }
            }
            else
            {
                if (solveCurrenTrialColor() == true)
                {
                    lblColorMatch.ForeColor = Color.Red;
                }
                else
                {
                    lblColorMatch.ForeColor = Color.Black;
                }
            }
        }
        
        private bool solveCurrentTrial()
        {
            int antTrialValue;
            int currTrialValue;

            if (currentTrial == 20)
            {
                antTrialValue = trials[(currentTrial - 2)];
                currTrialValue = trials[(currentTrial - 1)];
            }
            else if (currentTrial >= 1 && currentTrial <= 19)
            {
                antTrialValue = trials[(currentTrial - 1)];
                currTrialValue = trials[(currentTrial)];
            }
            else
            {
                return false;
            }


            if (antTrialValue == currTrialValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private bool solveCurrenTrialColor()
        {
            int antTrialValue, currTrialValue;

            if (currentTrial == 20)
            {
                antTrialValue = trialsColors[(currentTrial - 2)];
                currTrialValue = trialsColors[(currentTrial - 1)];
            }
            else if (currentTrial >= 1 && currentTrial <= 19)
            {
                antTrialValue = trialsColors[(currentTrial - 1)];
                currTrialValue = trialsColors[(currentTrial)];
            }
            else
            {
                return false;
            }


            if (antTrialValue == currTrialValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
