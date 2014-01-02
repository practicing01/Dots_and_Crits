function Module_Map_Bath_Salts::Initialize_Survivors(%this)
{

//Simset containing the possible Survivor tiles.  Made for randomly indexing.

%Simset_Survivor_Tiles=new SimSet();

%Script_Object_Survivor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Cute_Woman";

Handle_Asset=%this.Ass_Image_Cute_Woman;

Survivor_Type=0;//Cute Woman

};

%Simset_Survivor_Tiles.add(%Script_Object_Survivor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Survivor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Figure_Girl";

Handle_Asset=%this.Ass_Image_Figure_Girl;

Survivor_Type=1;//Figure Girl

};

%Simset_Survivor_Tiles.add(%Script_Object_Survivor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Survivor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Illumina";

Handle_Asset=%this.Ass_Image_Illumina;

Survivor_Type=2;//Illumina

};

%Simset_Survivor_Tiles.add(%Script_Object_Survivor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Survivor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Poco";

Handle_Asset=%this.Ass_Image_Poco;

Survivor_Type=3;//Poco

};

%Simset_Survivor_Tiles.add(%Script_Object_Survivor_Tile);

////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Survivor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Simple_Girl";

Handle_Asset=%this.Ass_Image_Simple_Girl;

Survivor_Type=4;//Simple Girl

};

%Simset_Survivor_Tiles.add(%Script_Object_Survivor_Tile);

////////////////////////////////////////////////////////////////////////////////
/**********************************************************************/

//4x4 logical grid containing a logical grid of 3x3 tiles of size 1024*1024, which can be further split logically.

%_4_by_4_Offset=(1024*3)/2;//Divide by 2 to get the middle because the center is the origin.

%_3_by_3_Offset=1024/2;

%_2_by_2_Offset=512/2;

%Simset_Random_3_by_3_Positions=new SimSet();

%Simset_Random_2_by_2_Positions=new SimSet();

for (%_4_by_4_y=-2;%_4_by_4_y<2;%_4_by_4_y++)
{

for (%_4_by_4_x=-2;%_4_by_4_x<2;%_4_by_4_x++)
{

%Simset_Random_3_by_3_Positions.deleteObjects();

for (%y=-1;%y<2;%y++)
{

for (%x=-1;%x<2;%x++)
{

%Script_Object_Tile=new ScriptObject()
{

X=%x;
Y=%y;

};

%Simset_Random_3_by_3_Positions.add(%Script_Object_Tile);

}

}

for (%y=0;%y<2;%y++)
{

for (%x=0;%x<2;%x++)
{

%Tile=%Simset_Random_3_by_3_Positions.getObject(getRandom(0,%Simset_Random_3_by_3_Positions.getCount()-1));

%Simset_Random_3_by_3_Positions.remove(%Tile);

%Tile.delete();

}

}

/**********************************************************************/

/*Set Survivor tiles.*/

for (%y=0;%y<%Simset_Random_3_by_3_Positions.getCount();%y++)
{

%Vector_2D_Tile_Position=%Simset_Random_3_by_3_Positions.getObject(%y);

%_3_by_3_x=%Vector_2D_Tile_Position.X;

%_3_by_3_y=%Vector_2D_Tile_Position.Y;

%Simset_Random_2_by_2_Positions.deleteObjects();

for (%y=0;%y<2;%y++)
{

for (%x=0;%x<2;%x++)
{

%Script_Object_Tile=new ScriptObject()
{

X=%x;
Y=%y;

};

%Simset_Random_2_by_2_Positions.add(%Script_Object_Tile);

}

}

for (%y=0;%y<2;%y++)
{

for (%x=0;%x<1;%x++)
{

%Tile=%Simset_Random_2_by_2_Positions.getObject(getRandom(0,%Simset_Random_2_by_2_Positions.getCount()-1));

%Simset_Random_2_by_2_Positions.remove(%Tile);

%Tile.delete();

}

}

%Random_Survivor_Tile=%Simset_Survivor_Tiles.getObject(getRandom(0,%Simset_Survivor_Tiles.getCount()-1));

for (%x=0;%x<%Simset_Random_2_by_2_Positions.getCount();%x++)
{

%Vector_2D_Tile_Position=%Simset_Random_2_by_2_Positions.getObject(%x);

%_2_by_2_x=%Vector_2D_Tile_Position.X;

%_2_by_2_y=%Vector_2D_Tile_Position.Y;

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_2_by_2_x*%_2_by_2_Offset)+(%_3_by_3_x*%_3_by_3_Offset)+(%_4_by_4_x*%_4_by_4_Offset);

%Vector_2D_Position.Y=(%_2_by_2_y*%_2_by_2_Offset)+(%_3_by_3_y*%_3_by_3_Offset)+(%_4_by_4_y*%_4_by_4_Offset);

%Vector_2D_Position=Scale_Vector_To_Camera(%Vector_2D_Position);

%Random_Survivor_Tile=%Simset_Survivor_Tiles.getObject(getRandom(0,%Simset_Survivor_Tiles.getCount()-1));

%Sprite_Survivor=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%Random_Survivor_Tile.Handle_Asset);
Image=%Random_Survivor_Tile.String_Asset_ID;
class="Class_Bath_Salts_Survivor";
CollisionCallback="true";
SceneLayer=16;
BodyType="static";

FixedAngle=true;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

Direction="0 1";//-1=Left/Up, 1=Right/Down

Base_Speed=5;

Current_Speed=5;

Survivor_Type=%Random_Survivor_Tile.Survivor_Type;

};

%Sprite_Survivor.setCollisionGroups(0,25,26,30);

%Collision_Shape_Index=%Sprite_Survivor.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%Random_Survivor_Tile.Handle_Asset));

%Sprite_Survivor.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

Scene_Dots_and_Crits.add(%Sprite_Survivor);

%this.Simset_Objects.add(%Sprite_Survivor);

%this.Object_Count++;

}

}

}

}

}
