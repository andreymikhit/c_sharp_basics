# _TurtleTraining_Program.cs
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
		static void WriteT()
		{
			Turtle.Angle = 0;
			Turtle.Move( 60 );
			//Turtle.Angle = 270;
			Turtle.TurnLeft();
			Turtle.Move( 20 );
			Turtle.Angle = 90;
			Turtle.Move( 40 );
		}

		static void WriteO(int size)
		{
			Turtle.Angle = 0;
			for ( int i = 0; i < 4; i++ )
			{
				Turtle.Move( size );
				Turtle.TurnRight();
			}
		}

		static void Main( string[] args )
		{
			Turtle.Speed = 8;
			Turtle.X = 200;
			Turtle.Y = 200;

			// Торт
			WriteT();

			Turtle.X = 260;
			Turtle.Y = 200;

			WriteO(30);


			Turtle.X = 400;
			Turtle.Y = 200;

			WriteT();

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
