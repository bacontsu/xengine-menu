# xEngine Menu
this is the experimental x-engine menu made in c# (winforms) that i scrapped because im moving to imgui

## UI Animation coded from scratch
such as smooth highlighter, the code :
```
public void MoveHighlight(int yTarget, int yCurrent) 
        {
            highlighter.Show();
            if (!busy)
            {

                busy = true;
                if (yTarget > yCurrent)
                {

                    for (int i = 0; i < (yTarget - yCurrent); i++)
                    {
                        Task.Delay(100);
                        highlighter.Top++;

                    }
                    busy = false;
                }
                else
                {
                    for (int i = 0; i < (yCurrent - yTarget); i++)
                    {
                        Task.Delay(100);
                        highlighter.Top--;

                    }
                    busy = false;

                }
            }
```
How to use it just call the function by ```MoveHighlight([target].Top, highlighter.Top);```

also fading opening animation using timer, code :
```
private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }

            Opacity += 0.1;
        }
```
just call it using ```timer1.Start();```
