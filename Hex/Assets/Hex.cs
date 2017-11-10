using UnityEngine;

/// <summary>
/// The Hex class defines the grid position, world space position, size,
/// neighbours, etc... of a Hex Tile. However, it does NOT interact with 
/// Unity directly in any way
/// </summary>
public class Hex  {

    
    public Hex(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = -(q + r);
    }

    // Q + R + S = 0
    // S = -(Q + R)

    public readonly int Q;  // Column
    public readonly int R;  // Row
    public readonly int S;  // Summ

    static readonly float WIFDTH_MULTILIER = Mathf.Sqrt(3) / 2;

    /// <summary>
    /// Returns the world-space psoition of this hex
    /// </summary>
    /// <returns>Position</returns>
    public Vector3 Position()
    {
        float radius = 1f;
        float height = radius * 2;
        float wight = WIFDTH_MULTILIER * height;

        float vert = height * 0.75f;
        float horiz = wight;

        return new Vector3(horiz * (Q + R/2f), 0, vert * R);
    }
}
