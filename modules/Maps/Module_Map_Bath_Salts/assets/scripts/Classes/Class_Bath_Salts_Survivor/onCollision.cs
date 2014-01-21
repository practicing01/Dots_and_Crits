function Class_Bath_Salts_Survivor::onCollision(%this,%Colliding_Object,%Collision_Details)
{

//if (%this.Health<=0){return;}

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

%this.Module_ID_Parent.Score++;

%this.Module_ID_Parent.Gui_Text_Score.setText(%this.Module_ID_Parent.Score);

%this.Visible=false;

schedule(20000,0,"Class_Bath_Salts_Survivor::Respawn",%this);

}

}
