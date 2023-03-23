using System.Runtime.CompilerServices;

namespace Matrix2D
{

    public class Matrix2D : IEquatable<Matrix2D>
    {
        private int[,] tablica = new int[2, 2];

        // konstruktor
        public Matrix2D(int a, int b, int c, int d)
        {
            tablica[0, 0] = a;
            tablica[0, 1] = b;
            tablica[1, 0] = c;
            tablica[1, 1] = d;
        }

        //ID oraz Zero
        public static readonly Matrix2D Id = new Matrix2D(1, 0, 1, 0);
        public static readonly Matrix2D Zero = new Matrix2D(0, 0, 0, 0);

        // ToString()

        public override string ToString()
        {
            if (tablica is null) return "Empty";

            return $"[({this.tablica[0, 0]},{this.tablica[0, 1]}),({this.tablica[1, 0]},{this.tablica[1,1]})";
        }

        //add
        public Matrix2D Add(Matrix2D other)
        {
            tablica[0,0] = tablica[0,0]+other.tablica[0,0];
            tablica[0,1] =
           
        }

        //equals
        public bool Equals(Matrix2D? other)
        {
            if( other is null ) return false;
            if( ReferenceEquals( this, other ) ) return true;

            return this.tablica[0, 0] == other.tablica[0, 0] &&
                this.tablica[1, 0] == other.tablica[1, 0] &&
                this.tablica[0, 1] == other.tablica[0, 1] &&
                this.tablica[1, 1] == other.tablica[1, 1];
        }

        public override bool Equals(object? obj) => 
            (obj is null || obj is not Matrix2D) ? false : Equals(obj as Matrix2D);

        public override int GetHashCode()
        {
            return HashCode.Combine( tablica );
        }

        public static bool operator == (Matrix2D a, Matrix2D b)
        {
            if (a is null && b is null) return true;
            if (a is null || b is null) return false;
            return a.Equals(b);
        }

        public static bool operator != (Matrix2D a, Matrix2D b) => !(a == b);

        //multiplication

    }
}