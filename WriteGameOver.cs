using System;

namespace Snake
{
    public class WriteGameOver
    {
        public WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition( xOffset, yOffset++ );
            WriteText( "============================", xOffset, yOffset++ );
            WriteText( "И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++ );
            WriteText( "============================", xOffset, yOffset++ );
            Params settings = new Params();
            Sounds sound = new Sounds(settings.GetResourcesFolder());
            sound.GameEnd();
        }

        static void WriteText( String text, int xOffset, int yOffset )
        {
            Console.SetCursorPosition( xOffset, yOffset );
            Console.WriteLine( text );
        }
    }
}