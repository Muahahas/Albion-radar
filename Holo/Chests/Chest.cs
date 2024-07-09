namespace Holo.Chests;

public sealed class Chest(int id, float posX, float posY, string name){
{
    public int ID { get; } = id;
    public float PosX { get; set; } = posX;
    public float PosY { get; set; } = posY;
    public string Name { get; set; } = name;
	
	   public override string ToString()
    {
        return "ID:" + ID +" PosX: " + PosX + " PosY: " + PosY + " Name:" + name;
    }