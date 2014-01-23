function Class_Kingless_Hill::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

%Player_Score=0;

for (%x=0;%x<%this.Simset_Player_Scores.getCount();%x++)
{

%Player_Score=%this.Simset_Player_Scores.getObject(%x);

if (%Player_Score.Composite_Sprite_ID_Player==%Colliding_Object)
{

break;

}
else
{

%Player_Score=0;

}

}

if (%Player_Score==0)
{

/**********************/

%Player_Object=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Player_Sprite_Data.Composite_Sprite==%Colliding_Object)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0){return;}

/**********************/

%New_Player_Score=new ScriptObject()
{

Composite_Sprite_ID_Player=%Colliding_Object;

Score=0;

Schedule_Handle_Score=0;

Gui_Score=0;

Connector_Name=%Player_Object.Connector_Name;

};

%this.Simset_Player_Scores.add(%New_Player_Score);

%Player_Score=%New_Player_Score;

/*************************/

%New_Player_Score.Gui_Score=new ImageFont()
{

Image="Module_Card_Kingless_Hill:Image_Font";

fontSize="2 2";

textAlignment="Center";

text=%New_Player_Score.Connector_Name SPC %New_Player_Score.Score;

Vector_2D_Mount_Offset="0 0";

};

Scene_Dots_and_Crits.add(%New_Player_Score.Gui_Score);

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y+=%this.Size.Y/2;

%New_Player_Score.Gui_Score.Vector_2D_Mount_Offset=%Vector_2D_Mount_Offset;

%this.Position=%this.Position;

/*************************/

%Half_Count=%this.Simset_Player_Scores.getCount()/2;

for (%x=0;%x<%this.Simset_Player_Scores.getCount();%x++)
{

%Player_Score=%this.Simset_Player_Scores.getObject(%x);

%Player_Score.Gui_Score.Vector_2D_Mount_Offset.X=(%x-%Half_Count)*%Player_Score.Gui_Score.getSizeX();

%Player_Score.Gui_Score.mount(%this,%Player_Score.Gui_Score.Vector_2D_Mount_Offset,0,true,mDegToRad(0));

}

}
else
{

cancel(%Player_Score.Schedule_Handle_Score);

}

%Player_Score.Schedule_Handle_Score=schedule(1000,0,"Module_Card_Kingless_Hill::Score",%this.Module_ID_Parent,%this,%Player_Score);

}

}
