using System.Runtime.Serialization;

namespace Monogon.Engine.Struct;

/// <summary>
/// A mix of Vector2 and Vector3 aimed at storing a little more information, rotation, scale, and position.
/// I'm not gonna work on this for a while though, I got more PRESSING things to pay attention to. *ahem* LDTKSupport.cs *ahem*
/// </summary>
[DataContract]
public struct VectorInfo
{
    [DataMember]
    public float x;
    [DataMember]
    
    public float y;
    // Future proofing if I ever want to make Monogon 3D-compatible
    [DataMember]
    public float z;
    
    [DataMember]
    public float rot2D;
    
    // Future proofing if I ever want to make Monogon 3D-compatible
    [DataMember]
    public float rot3D_X;
    [DataMember]
    public float rot3D_Y;
    [DataMember]
    public float rot3D_Z;
    
    [DataMember]
    public float scaleX;
    [DataMember]
    public float scaleY;
    
    // Future proofing if I ever want to make Monogon 3D-compatible
    [DataMember]
    public float scaleZ;
}