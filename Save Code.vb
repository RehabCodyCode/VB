 Save Code
private void SaveItemsInTable()
        {
            SqlConnection db = new SqlConnection(SHD.CnStr);
            try
            {
                String cmdstring = " Delete From WKRoomItemLayout where RoomID = '";
                cmdstring += RoomID + "'";
                db.Open();
                SqlCommand cmd = new SqlCommand(cmdstring, db);
                cmd.ExecuteNonQuery();
                int i = 0;
                foreach (Control c in this.panel1.Controls)
                {
                    if (c.Tag != null)
                        if (c.Tag.ToString() == "IT")
                        {
                            SHDFurn C = (SHDFurn)c;
                            cmd.CommandText = "Insert into WKRoomItemLayout ( ItemCode , RoomID, ItemID , ItmTextureID, D2X1, D2Z1, D2XW, D2XL, D3PX, D3PY, D3PZ, D3RX, D3RY, D3RZ ) values (";

                            cmd.CommandText += "'" + C.Name + "','"; 
                            cmd.CommandText += RoomID + "','";       
                            cmd.CommandText += C.ItemCode + "','";   
                            cmd.CommandText += C.DefaultTexture + "',"; 

                            cmd.CommandText += C.Location.X + ","; 
                            cmd.CommandText += C.Location.Y + ",";  
                            cmd.CommandText += C.Location.X + ",";  
                            cmd.CommandText += C.Location.Y + ",";  
                            cmd.CommandText += C.Location.X + ",";  
                            cmd.CommandText +=  "-50,"; 
                            cmd.CommandText += C.Location.Y + ",";       
                            cmd.CommandText += C.RotX + ",";       
                            cmd.CommandText += C.RotY  +   ",";       
                            cmd.CommandText += C.RotZ + ")";        
                                                        cmd.ExecuteNonQuery();
                            
                            i++;
                        }

                }
                db.Close();
            }
            catch (System.Exception Err)
            {
                MessageBox.Show(Err.Message.ToString());
            }
        }
