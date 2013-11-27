function Module_Card_Laser::Update_Laser_Beam(%this,%Player_Object,%World_Position)
{

%Vector_2D_Player_Position=%Player_Object.Player_Information.Player_Sprite_Data.Composite_Sprite.Position;

%Player_Object.Sprite_Laser_Beam.setSizeY(Vector2Distance(%Vector_2D_Player_Position,%World_Position));

%Player_Object.Sprite_Laser_Beam.clearCollisionShapes();

%Collision_Shape_Index=%Player_Object.Sprite_Laser_Beam.createPolygonBoxCollisionShape(%Player_Object.Sprite_Laser_Beam.Size);

%Player_Object.Sprite_Laser_Beam.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Vector_2D_Player_Size=%Player_Object.Player_Information.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Angle=(Vector2AngleToPoint(%Vector_2D_Player_Position,%World_Position));

%Vector_To_Direction=Vector2Direction(%Angle,%Player_Object.Sprite_Laser_Beam.Size.Y/2);

%Player_Object.Sprite_Laser_Beam.Angle=%Angle+90;

%Player_Object.Sprite_Laser_Beam.Position=Vector2Add(%Vector_2D_Player_Position,%Vector_To_Direction);

%Player_Object.Schedule_Laser_Beam=schedule(62,0,"Module_Card_Laser::Update_Laser_Beam",%this,%Player_Object,%World_Position);

}
