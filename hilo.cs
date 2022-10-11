protected override void OnPaint(PaintEventArgs e)
{
  // Allocate graphics device context
    cardDrawing.Begin( e.Graphics );

      // Do Card drawing
        . . .

          // Release graphics device context
            cardDrawing.End();

              // Draw anything else

                base.OnPaint(e);
                }
protected override void OnPaint(PaintEventArgs e)
{
  // Allocate graphics device context
    cardDrawing.Begin( e.Graphics );

      // Do Card drawing
        . . .

          // Release graphics device context
            cardDrawing.End();

              // Draw anything else

                base.OnPaint(e);
                }
if( cardDrawing != null )
{
  cardDrawing.Dispose();
  }
 cardDrawing.DrawRotatedCard( new Point(120,120), 90, 
        Card.ToCardIndex( CardSuit.Hearts, CardRank.King ) );
public class Deck
{
  private int[] CardArray = new int[52];

    /// <summary>
      /// Initializes deck with the 52 integers.
        /// </summary>
          public Deck()
            {
                // Deck uses RankCollated cards 0 - 51
                    for( int i = 0; i < 52; i++ )
                        {
                              CardArray[i] = i;
                                  }
                                    }
                                    }
/// <summary>
/// Randomly rearrange integers
/// </summary>
public void Shuffle()
{
  int[] newArray = new int[52];
    bool[] used = new bool[52];

      for( int j = 0; j < 52; j++ )
        {
            used[j] = false;
              }

                Random rnd = new Random();
                  int iCount = 0;
                    int iNum;

                      while( iCount < 52 )
                        {
                            iNum = rnd.Next( 0, 52 ); // between 0 and 51

                                if( used[iNum] == false )
                                    {
                                          newArray[iCount] = iNum;
                                                used[iNum] = true;
                                                      iCount++;
                                                          }
                                                            }

                                                              // Load original array with shuffled array
                                                                CardArray = newArray;
                                                                