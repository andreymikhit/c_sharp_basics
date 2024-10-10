_TurtleTraining_Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
	class Program
	{
		static void WriteT(int x, int y, int size)
		{
			Turtle.X = x;
			Turtle.Y = y;
			Turtle.Angle = 0;
			Turtle.Move( size );
			//Turtle.Angle = 270;
			Turtle.TurnLeft();
			Turtle.Move( size / 3 );
			Turtle.Angle = 90;
			Turtle.Move( size * 2 / 3 );
		}

		static void WriteO( int x, int y, int size )
		{
			Turtle.X = x;
			Turtle.Y = y;
			Turtle.Angle = 0;
			for ( int i = 0; i < 4; i++ )
			{
				Turtle.Move( size );
				Turtle.TurnRight();
			}
		}

		static void WriteR( int x, int y, int size )
		{
			Turtle.X = x;
			Turtle.Y = y;
			Turtle.Angle = 0;
			Turtle.Move( size / 2 );
			WriteO( x, y - size/2, size / 2 );
		}

		static void Main( string[] args )
		{
			Turtle.Speed = 8;


			// Торт
			WriteT(200, 200, 60);

			WriteO(240, 200, 30);

			WriteR(300, 200, 30 );
		
			WriteT( 340, 200, 30 );

			// Забор
			//for(int i = 0; i < 4; i++)
			//{
			//	Turtle.Move( 20 );
			//	Turtle.TurnRight();
			//	Turtle.Move( 20 );
			//	Turtle.TurnRight();
			//	Turtle.Move( 20 );
			//	Turtle.TurnLeft();
			//	Turtle.Move( 20 );
			//	Turtle.TurnLeft();
			//}


			// Шестиугольник
			//int i = 0;
			//while ( i < 6 )
			//{
			//	Turtle.Move( 100 );
			//	Turtle.Turn( 60 );
			//	i++;
			//}
		}
	}
}
