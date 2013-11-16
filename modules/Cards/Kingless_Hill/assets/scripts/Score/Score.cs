function Module_Card_Kingless_Hill::Score(%this,%Hill,%Player_Score)
{

%Player_Score.Score++;

%Player_Score.Gui_Score.setText(%Player_Score.Connector_Name SPC %Player_Score.Score);

%Half_Count=%Hill.Simset_Player_Scores.getCount()/2;

for (%x=0;%x<%Hill.Simset_Player_Scores.getCount();%x++)
{

%Hill_Player_Score=%Hill.Simset_Player_Scores.getObject(%x);

%Hill_Player_Score.Gui_Score.Vector_2D_Mount_Offset.X=(%x-%Half_Count)*%Hill_Player_Score.Gui_Score.getSizeX();

%Hill_Player_Score.Gui_Score.mount(%Hill,%Hill_Player_Score.Gui_Score.Vector_2D_Mount_Offset,0,true,mDegToRad(0));

}

%Player_Score.Schedule_Handle_Score=schedule(1000,0,"Module_Card_Kingless_Hill::Score",%this,%Hill,%Player_Score);

}
