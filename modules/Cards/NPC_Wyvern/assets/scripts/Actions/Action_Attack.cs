function Module_Card_NPC_Wyvern::Action_Attack(%this,%Player_Information,%Object_Module_ID,%Object_Game_Connection_Handle,%Object_Index,%Unit_Object_Index,%Attack)
{

%Script_Object_Player=%Player_Information.Player_Sprite_Data.Sprite.Script_Object_Parent;

%Sprite_Unit=-1;

for (%x=0;%x<%this.Simset_Objects.getCount();%x++)
{

%Object=%this.Simset_Objects.getObject(%x);

if (%Object.Object_Index==%Unit_Object_Index&&%Object.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

%Sprite_Unit=%Object;

break;

}

}

if (!isObject(%Sprite_Unit)){return;}

/*******************************************************************/

//Go through object's module if the object exists based on game connection handle.

if (!isObject(%Object_Module_ID)){return;}

%Object_Target=0;

if (%Object_Index==-1)//Player being attacked.
{

for (%x=0;%x<%Object_Module_ID.Simset_Player_Information.getCount();%x++)
{

%Object=%Object_Module_ID.Simset_Player_Information.getObject(%x);

if (%Object.Game_Connection_Handle==%Object_Game_Connection_Handle)
{

%Object_Target=%Object;

break;

}

}

}
else
{

for (%x=0;%x<%Object_Module_ID.Simset_Objects.getCount();%x++)
{

%Object=%Object_Module_ID.Simset_Objects.getObject(%x);

if (%Object.Game_Connection_Handle==%Object_Game_Connection_Handle&&%Object.Object_Index==%Object_Index)
{

%Object_Target=%Object;

break;

}

}

}

if (!%Object_Target){return;}

/*******************************************************************/

if (%Attack==0)
{

%Sprite_Unit.Animation_Set("Sting");

if (%Object_Index==-1)//Player being attacked.
{

%Object_Module_ID.Action_Update_Health(%Object_Target,%Object_Target.Game_Connection_Handle,1,%Sprite_Unit.Current_Attack);

}
else
{

%Object_Module_ID.Action_Update_Health(%Player_Information,%Object_Target.Game_Connection_Handle,%Object_Target.Object_Index,1,%Sprite_Unit.Current_Attack);

}

}
else if (%Attack==1)
{

%Sprite_Unit.Animation_Set("Breath");

/*****************************************/

%this.NPC_Wyvern_Count++;//Going to use this for fire balls too.

%Vector_2D_Target_Position="0 0";

if (%Object_Index==-1)//Player being attacked.
{

%Vector_2D_Target_Position=%Object_Target.Sprite.Position;

}
else
{

%Vector_2D_Target_Position=%Object_Target.Position;

}

%Sprite_Fire_Ball=new Sprite()
{

Position=%Sprite_Unit.Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_NPC_Wyvern_Fire_Ball);
Image="Module_Card_NPC_Wyvern:Image_NPC_Wyvern_Fire_Ball";
Animation="Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fire_Ball";
class="Class_NPC_Wyvern_Fire_Ball";
CollisionCallback="true";
SceneLayer=14;
Angle=(Vector2AngleToPoint(%Sprite_Unit.Position,%Vector_2D_Target_Position)+90)%360;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Sprite_Unit.Game_Connection_Handle;

Object_Index=%this.NPC_Wyvern_Count;

Health=100;

};

%Sprite_Fire_Ball.setCollisionGroups(0,25,26,30);

%Vector_2D_Target_Player_Sprite_Size=%Sprite_Unit.getSize();

%Square_Size=%Sprite_Fire_Ball.Size;

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%Sprite_Fire_Ball.createCircleCollisionShape(%Radius);

%Sprite_Fire_Ball.setCollisionShapeIsSensor(%Collision_Shape_Index,true);


//Offset the fireball so it doesn't collide with the parent wyvern when spawned.

/*if (%Sprite_Unit.Vector_2D_Direction.X==0)//Wyvern going up or down.
{

if (%Sprite_Unit.Vector_2D_Direction.Y==0)//Not possible :P, lets set to down.
{

//%Sprite_Fire_Ball.Position.Y-=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==-1)//Wyvern going down.
{

//%Sprite_Fire_Ball.Position.Y-=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==1)//Wyvern going up.
{

//%Sprite_Fire_Ball.Position.Y+=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Sprite_Fire_Ball.Angle=180;

}

}
else if (%Sprite_Unit.Vector_2D_Direction.X==-1)//Wyvern going left.
{

//%Sprite_Fire_Ball.Position.X-=(%Vector_2D_Target_Player_Sprite_Size.X/2)+(%Square_Size.X/2);

%Sprite_Fire_Ball.Angle=90;

if (%Sprite_Unit.Vector_2D_Direction.Y==-1)//Wyvern going down.
{

//%Sprite_Fire_Ball.Position.Y-=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Sprite_Fire_Ball.Angle-=45;

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==1)//Wyvern going up.
{

//%Sprite_Fire_Ball.Position.Y+=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Sprite_Fire_Ball.Angle+=45;

}

}
else if (%Sprite_Unit.Vector_2D_Direction.X==1)//Wyvern going right.
{

//%Sprite_Fire_Ball.Position.X+=(%Vector_2D_Target_Player_Sprite_Size.X/2)+(%Square_Size.X/2);

%Sprite_Fire_Ball.Angle=270;

if (%Sprite_Unit.Vector_2D_Direction.Y==-1)//Wyvern going down.
{

//%Sprite_Fire_Ball.Position.Y-=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Sprite_Fire_Ball.Angle+=45;

}
else if (%Sprite_Unit.Vector_2D_Direction.Y==1)//Wyvern going up.
{

//%Sprite_Fire_Ball.Position.Y+=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%Square_Size.Y/2);

%Sprite_Fire_Ball.Angle-=45;

}

}*/

Scene_Dots_and_Crits.add(%Sprite_Fire_Ball);

%this.Simset_Objects.add(%Sprite_Fire_Ball);

%Sprite_Fire_Ball.moveTo(%Vector_2D_Target_Position,30,true,false);

/*****************************************/

}

}
