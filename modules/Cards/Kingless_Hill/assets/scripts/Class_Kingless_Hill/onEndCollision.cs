function Class_Kingless_Hill::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

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

if (%Player_Score==0){return;}

cancel(%Player_Score.Schedule_Handle_Score);

}

}
