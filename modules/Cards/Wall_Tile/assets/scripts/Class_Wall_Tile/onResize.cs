function Class_Wall_Tile::onResize(%this)
{

%this.clearCollisionShapes();

%this.createPolygonBoxCollisionShape(%this.Size);

}
