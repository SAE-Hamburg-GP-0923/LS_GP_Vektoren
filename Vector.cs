namespace LS_GP_Vektoren;

public class Vector
{
    // Drei Float Attribute
    public float m_x = 0;
    public float m_y = 0;
    public float m_z = 0;

    // Standard Vektor in dem x,y,z auf 0 gesetzt werden
    public Vector()
    {
        m_x = 0;
        m_y = 0;
        m_z = 0;
    }

    // Einen Konstruktor in dem x,y,z mit Parametern initialisiert werden
    public Vector(float x, float y, float z)
    {
        m_x = x;
        m_y = y;
        m_z = z;
    }

    // Operator overloading
    public static Vector operator +(Vector lhs, Vector rhs) =>
        new Vector(lhs.m_x + rhs.m_x, lhs.m_y + rhs.m_y, lhs.m_z + rhs.m_z);

    public static Vector operator -(Vector lhs, Vector rhs) =>
        new Vector(lhs.m_x - rhs.m_x, lhs.m_y - rhs.m_y, lhs.m_z - rhs.m_z);

    public static Vector operator *(Vector vec, float scalar) =>
        new Vector(vec.m_x * scalar, vec.m_y * scalar, vec.m_z * scalar);

    // Non-Static Methode um die Distanz zwischen zwei Vektoren zu berechnen
    public static float GetDistance(Vector lhs, Vector rhs)
    {
        return MathF.Sqrt(MathF.Pow(lhs.m_x - rhs.m_x, 2) + MathF.Pow(lhs.m_y - rhs.m_y, 2) +
                          MathF.Pow(lhs.m_z - rhs.m_z, 2));
    }
    
    // Non-Static Methode um die Distanz zwischen dem und einem anderen Vector
    public float GetDistance(Vector other)
    {
        return GetDistance(this, other);
    }

    public override string ToString()
    {
        return $"{m_x} : {m_y} : {m_z}";
    }

    // Berechnet die Quadratlänge des Vektors
    public float GetSquareMagnitude()
    {
        return MathF.Pow(m_x, 2f) + MathF.Pow(m_y, 2f) + MathF.Pow(m_z, 2f);
    }

    // Berechnet die länge des Vektors
    public float GetMagnitude()
    {
        return MathF.Sqrt(GetSquareMagnitude());
    }
}