function Class_Bath_Salts_Monster::AI(%this)
{

if (!isObject(%this)){return;}

//Check if player is close.

%Scaled_Resolution=Scale_Vector_To_Camera($Resolution);

if (Vector2Distance(%this.Position,$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Position)
<=Vector2Distance("0 0",Scale_Vector_To_Camera($Resolution.X/2 SPC $Resolution.Y/2)))
{

/************************************************************/



/************************************************************/

}

%this.Schedule_Handle_AI=schedule(1000,0,"Class_Bath_Salts_Monster::AI",%this);

}