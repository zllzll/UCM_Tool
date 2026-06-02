using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using UCM_Tools.Config;
using UCM_Tools.Tools;

namespace UCM_Tools.Tools
{
    public class VTKHelper
    {

		public class LineInfo
        {
			public double X0
			{
				get;
				set;
			}

			public double Y0
			{
				get;
				set;
			}

			public double Z0
			{
				get;
				set;
			}

			public double X1
			{
				get;
				set;
			}

			public double Y1
			{
				get;
				set;
			}

			public double Z1
			{
				get;
				set;
			}

			public int firstpoint
			{
				get;
				set;
			}

			public int secondpoint
			{
				get;
				set;
			}
		}


        public vtkActor DrawGrid()
        {
            vtkPoints points = vtkPoints.New();
            vtkCellArray cells = vtkCellArray.New();
            vtkUnsignedCharArray vtkUnsignedCharArray = vtkUnsignedCharArray.New();
            vtkUnsignedCharArray.SetNumberOfComponents(3);
            vtkPolyData vtkPolyData = vtkPolyData.New();
            Color color = SystemSetting.VTKBackColor?Color.LightGray : Color.FromArgb(56, 56, 56);
			int i = 0;
            double xyZ = SystemSetting.B_OtherGrid ? (double)SystemSetting.ZMin : 0.0;
            for (double column = SystemSetting.XMin; column <= SystemSetting.XMax; column = column + SystemSetting.XStep)
            {
                VTKHelper.LineInfo lineInfo = new VTKHelper.LineInfo();
                lineInfo.X0 = (double)column;
                lineInfo.Y0 = (double)SystemSetting.YMin;
                lineInfo.Z0 = xyZ;
                lineInfo.X1 = (double)column;
                lineInfo.Y1 = (double)SystemSetting.YMax;
                lineInfo.Z1 = xyZ;
                lineInfo.firstpoint = i * 2;
				lineInfo.secondpoint = i * 2 + 1;
                vtkPolyLine vtkpolyLine = vtkPolyLine.New();
                vtkPolyData = this.DrawLine(vtkpolyLine, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfo, color);
				i++;
            }
            for (double row = SystemSetting.YMin; row <= SystemSetting.YMax; row = row + SystemSetting.YStep)
            {

				VTKHelper.LineInfo lineInfo = new VTKHelper.LineInfo();
				lineInfo.X0 = SystemSetting.XMin;
				lineInfo.Y0 = row;
				lineInfo.Z0 = xyZ;
				lineInfo.X1 = SystemSetting.XMax;
				lineInfo.Y1 = row;
				lineInfo.Z1 = xyZ;

				lineInfo.firstpoint = i * 2;
				lineInfo.secondpoint = i * 2 + 1;
				vtkPolyLine vtkpolyLine2 = vtkPolyLine.New();
				vtkPolyData = this.DrawLine(vtkpolyLine2, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfo, color);
				i++;

            }
            if (SystemSetting.B_OtherGrid)
            {
                // XZ平面 (Y=YMax)
                for (double column = SystemSetting.XMin; column <= SystemSetting.XMax; column = column + SystemSetting.XStep)
                {
                    VTKHelper.LineInfo lineInfo = new VTKHelper.LineInfo();
                    lineInfo.X0 = (double)column;
                    lineInfo.Y0 = (double)SystemSetting.YMax;
                    lineInfo.Z0 = (double)SystemSetting.ZMin;
                    lineInfo.X1 = (double)column;
                    lineInfo.Y1 = (double)SystemSetting.YMax;
                    lineInfo.Z1 = (double)SystemSetting.ZMax;
                    lineInfo.firstpoint = i * 2;
                    lineInfo.secondpoint = i * 2 + 1;
                    vtkPolyLine vtkpolyLine = vtkPolyLine.New();
                    vtkPolyData = this.DrawLine(vtkpolyLine, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfo, color);
                    i++;
                }
                for (double row = SystemSetting.ZMin; row <= SystemSetting.ZMax; row = row + SystemSetting.ZStep)
                {
                    VTKHelper.LineInfo lineInfo = new VTKHelper.LineInfo();
                    lineInfo.X0 = SystemSetting.XMin;
                    lineInfo.Y0 = (double)SystemSetting.YMax;
                    lineInfo.Z0 = row;
                    lineInfo.X1 = SystemSetting.XMax;
                    lineInfo.Y1 = (double)SystemSetting.YMax;
                    lineInfo.Z1 = row;
                    lineInfo.firstpoint = i * 2;
                    lineInfo.secondpoint = i * 2 + 1;
                    vtkPolyLine vtkpolyLine2 = vtkPolyLine.New();
                    vtkPolyData = this.DrawLine(vtkpolyLine2, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfo, color);
                    i++;
                }
                // YZ平面 (X=XMin)
                for (double column = SystemSetting.YMin; column <= SystemSetting.YMax; column = column + SystemSetting.YStep)
                {
                    VTKHelper.LineInfo lineInfo = new VTKHelper.LineInfo();
                    lineInfo.X0 = (double)SystemSetting.XMin;
                    lineInfo.Y0 = (double)column;
                    lineInfo.Z0 = (double)SystemSetting.ZMin;
                    lineInfo.X1 = (double)SystemSetting.XMin;
                    lineInfo.Y1 = (double)column;
                    lineInfo.Z1 = (double)SystemSetting.ZMax;
                    lineInfo.firstpoint = i * 2;
                    lineInfo.secondpoint = i * 2 + 1;
                    vtkPolyLine vtkpolyLine = vtkPolyLine.New();
                    vtkPolyData = this.DrawLine(vtkpolyLine, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfo, color);
                    i++;
                }
                for (double row = SystemSetting.ZMin; row <= SystemSetting.ZMax; row = row + SystemSetting.ZStep)
                {
                    VTKHelper.LineInfo lineInfo = new VTKHelper.LineInfo();
                    lineInfo.X0 = (double)SystemSetting.XMin;
                    lineInfo.Y0 = SystemSetting.YMin;
                    lineInfo.Z0 = row;
                    lineInfo.X1 = (double)SystemSetting.XMin;
                    lineInfo.Y1 = SystemSetting.YMax;
                    lineInfo.Z1 = row;
                    lineInfo.firstpoint = i * 2;
                    lineInfo.secondpoint = i * 2 + 1;
                    vtkPolyLine vtkpolyLine2 = vtkPolyLine.New();
                    vtkPolyData = this.DrawLine(vtkpolyLine2, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfo, color);
                    i++;
                }
            }
            vtkPolyDataMapper vtkPolyDataMapper = vtkPolyDataMapper.New();
            vtkPolyDataMapper.SetInput(vtkPolyData);
            vtkActor vtkActor = vtkActor.New();
            vtkActor.SetMapper(vtkPolyDataMapper);
			//vtkActor.GetProperty().SetOpacity(0.5);//设置透明度
			vtkActor.GetProperty().SetLineWidth(2f);
            // 关键：应用全局变换
            if (SystemSetting.NonUniformScale)
                vtkActor.SetUserTransform(SystemSetting.GlobalTransform);
            return vtkActor;
        }

        public vtkPolyData DrawLine(vtkPolyLine vtkpolyLine, vtkPoints points, vtkCellArray cells, vtkUnsignedCharArray colors, vtkPolyData linesPolyData, VTKHelper.LineInfo line, Color color)
        {
            points = this.DoublePoint(points, line);
            vtkpolyLine.GetPointIds().SetNumberOfIds(2);
            vtkpolyLine.GetPointIds().SetId(0, line.firstpoint);
            vtkpolyLine.GetPointIds().SetId(1, line.secondpoint);
            cells.InsertNextCell(vtkpolyLine);
            colors.InsertNextValue(color.R);
            colors.InsertNextValue(color.G);
            colors.InsertNextValue(color.B);
            linesPolyData.SetPoints(points);
            linesPolyData.SetLines(cells);
            linesPolyData.GetCellData().SetScalars(colors);
            return linesPolyData;
        }

		public vtkPoints DoublePoint(vtkPoints doublepoints, VTKHelper.LineInfo line)
		{
			doublepoints.InsertNextPoint(line.X0, line.Y0, line.Z0);
			doublepoints.InsertNextPoint(line.X1, line.Y1, line.Z1);
			return doublepoints;
		}
		public vtkActor DrawAxis(double length)
		{
			List<vtkActor> list = new List<vtkActor>();
			vtkActor vtkActor = vtkActor.New();
			vtkPoints points = vtkPoints.New();
			vtkCellArray cells = vtkCellArray.New();

			vtkUnsignedCharArray vtkUnsignedCharArray = vtkUnsignedCharArray.New();
			vtkUnsignedCharArray.SetNumberOfComponents(3);
			vtkPolyData vtkPolyData = vtkPolyData.New();

			VTKHelper.LineInfo lineInfo = new VTKHelper.LineInfo();
			Color color = Color.FromArgb(0, 0, 255);
			lineInfo.X0 = 0;
			lineInfo.Y0 = 0;
			lineInfo.Z0 = 0.0;
			lineInfo.X1 = 0;
			lineInfo.Y1 = length;
			lineInfo.Z1 = 0.0;
			lineInfo.firstpoint = 0;
			lineInfo.secondpoint = 1;
			vtkPolyLine vtkpolyLine = vtkPolyLine.New();
			vtkPolyData = this.DrawLine(vtkpolyLine, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfo, color);


			VTKHelper.LineInfo lineInfoX = new VTKHelper.LineInfo();
			Color color2 = Color.FromArgb(255, 0, 0);
			lineInfoX.X0 = 0;
			lineInfoX.Y0 = 0;
			lineInfoX.Z0 = 0.0;
			lineInfoX.X1 = length;
			lineInfoX.Y1 = 0;
			lineInfoX.Z1 = 0.0;
			lineInfoX.firstpoint = 2;
			lineInfoX.secondpoint = 3;
			vtkPolyLine vtkpolyLine2 = vtkPolyLine.New();
			vtkPolyData = this.DrawLine(vtkpolyLine2, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfoX, color2);


			VTKHelper.LineInfo lineInfoZ = new VTKHelper.LineInfo();
			Color color3 = Color.FromArgb(255, 255, 0);
			lineInfoZ.X0 = 0;
			lineInfoZ.Y0 = 0;
			lineInfoZ.Z0 = 0.0;
			lineInfoZ.X1 = 0;
			lineInfoZ.Y1 = 0;
			lineInfoZ.Z1 = length;
			lineInfoZ.firstpoint = 4;
			lineInfoZ.secondpoint = 5;
			vtkPolyLine vtkpolyLine3 = vtkPolyLine.New();
			vtkPolyData = this.DrawLine(vtkpolyLine3, points, cells, vtkUnsignedCharArray, vtkPolyData, lineInfoZ, color3);

			vtkPolyDataMapper vtkPolyDataMapper = vtkPolyDataMapper.New();
			vtkPolyDataMapper.SetInput(vtkPolyData);
			vtkActor vtkActor2 = vtkActor.New();
			vtkActor2.SetMapper(vtkPolyDataMapper);
			vtkActor2.GetProperty().SetLineWidth(3f);
            // 关键：应用全局变换
            if (SystemSetting.NonUniformScale)
                vtkActor2.SetUserTransform(SystemSetting.GlobalTransform);
			if (SystemSetting.B_OtherGrid)
				vtkActor2.VisibilityOff();
			else
                vtkActor2.VisibilityOn();
            return vtkActor2;
		}

		public List<vtkFollower> Scale(List<vtkFollower> followers)
		{
			bool otherGrid = SystemSetting.B_OtherGrid;
			for (int i = SystemSetting.XMin; i <= SystemSetting.XMax; i = i + SystemSetting.XStep)
			{
				if (otherGrid && i == SystemSetting.XMax)
					continue;
				vtkVectorText vtkVectorText = vtkVectorText.New();
				string text = Convert.ToString(i);
				vtkVectorText.SetText(text);
				vtkVectorText.Update();
				double[] bounds = vtkVectorText.GetOutput().GetBounds();
				double textW = bounds[1] - bounds[0];
				double textH = bounds[3] - bounds[2];
				double xPos = (double)i - bounds[0] - textW / 2.0;
				double yPos = otherGrid ? (double)SystemSetting.YMin - textH - 2 : -2.0 - textH;
				double zPos = otherGrid ? (double)SystemSetting.ZMin - 2.0 : -2.0;

				vtkPolyDataMapper vtkPolyDataMapper = vtkPolyDataMapper.New();
				vtkPolyDataMapper.SetInputConnection(vtkVectorText.GetOutputPort());
				vtkFollower vtkFollower = vtkFollower.New();
				vtkFollower.SetMapper(vtkPolyDataMapper);
				vtkFollower.SetPosition(xPos, yPos, zPos);
				vtkFollower.GetProperty().SetPointSize(0.1f);
				if (SystemSetting.VTKBackColor)
					vtkFollower.GetProperty().SetColor(0.502, 0.502, 0.502);
				if (SystemSetting.NonUniformScale)
					vtkFollower.SetUserTransform(SystemSetting.GlobalTransform);
				followers.Add(vtkFollower);
				vtkPolyDataMapper.Dispose();
				vtkVectorText.Dispose();
			}
			for (int j = SystemSetting.YMin; j <= SystemSetting.YMax; j += SystemSetting.YStep)
			{
				if (j == 0 || (otherGrid && j == SystemSetting.YMax))
					continue;
				vtkVectorText vtkVectorText2 = vtkVectorText.New();
				string text2 = Convert.ToString(j);
				vtkVectorText2.SetText(text2);
				vtkVectorText2.Update();
				double[] bounds = vtkVectorText2.GetOutput().GetBounds();
				double textW = bounds[1] - bounds[0];
				double textH = bounds[3] - bounds[2];
				double xPos = otherGrid ? (double)SystemSetting.XMax + 2 : (double)(SystemSetting.XMin - 2) - textW;
				double yPos = (double)j - bounds[2] - textH /2.0d;
				double zPos = otherGrid ? (double)SystemSetting.ZMin - 2.0 : -2.0;
				vtkPolyDataMapper vtkPolyDataMapper2 = vtkPolyDataMapper.New();
				vtkPolyDataMapper2.SetInputConnection(vtkVectorText2.GetOutputPort());
				vtkFollower vtkFollower2 = vtkFollower.New();
				vtkFollower2.SetMapper(vtkPolyDataMapper2);
				vtkFollower2.SetPosition(xPos, yPos, zPos);
				vtkFollower2.GetProperty().SetPointSize(0.1f);
				if (SystemSetting.VTKBackColor)
					vtkFollower2.GetProperty().SetColor(0.502, 0.502, 0.502);
				if (SystemSetting.NonUniformScale)
					vtkFollower2.SetUserTransform(SystemSetting.GlobalTransform);
				followers.Add(vtkFollower2);
				vtkPolyDataMapper2.Dispose();
				vtkVectorText2.Dispose();
			}
			if (otherGrid)
			{
				for (int k = SystemSetting.ZMin; k <= SystemSetting.ZMax; k += SystemSetting.ZStep)
				{
					if (k == SystemSetting.ZMax || k== SystemSetting.ZMin)
						continue;
					vtkVectorText vtkVectorText3 = vtkVectorText.New();
					string text3 = Convert.ToString(k);
					vtkVectorText3.SetText(text3);
					vtkVectorText3.Update();
					double[] bounds = vtkVectorText3.GetOutput().GetBounds();
					double textW = bounds[1] - bounds[0];
					double textD = bounds[3] - bounds[2];
					double zPos = (double)k - textD / 2.0;
					vtkPolyDataMapper vtkPolyDataMapper3 = vtkPolyDataMapper.New();
					vtkPolyDataMapper3.SetInputConnection(vtkVectorText3.GetOutputPort());
					vtkFollower vtkFollower3 = vtkFollower.New();
					vtkFollower3.SetMapper(vtkPolyDataMapper3);
					vtkFollower3.SetPosition((double)SystemSetting.XMax + 2, (double)SystemSetting.YMax, zPos);
					vtkFollower3.GetProperty().SetPointSize(0.1f);
					if (SystemSetting.VTKBackColor)
						vtkFollower3.GetProperty().SetColor(0.502, 0.502, 0.502);
					if (SystemSetting.NonUniformScale)
						vtkFollower3.SetUserTransform(SystemSetting.GlobalTransform);
					followers.Add(vtkFollower3);
					vtkPolyDataMapper3.Dispose();
					vtkVectorText3.Dispose();
				}
			}

			return followers;
		}

        public static vtkActor ShowPointCloud2(vtkActor vtkActor, vtkFloatArray myscalar, vtkPoints Points, vtkPolyData polyData, vtkLookupTable lookupTable, vtkVertexGlyphFilter glyphFilter, vtkPolyDataMapper pointmap, List<TargetInfo.RadarTargetInfoStruct> point)
        {

            bool flag3 = point != null;
            if (flag3)
            {
                if (SystemSetting.Default_Color)
                    pointmap = HeightColorSchemeDefult(myscalar, Points, polyData, lookupTable, glyphFilter, pointmap, point, 1.0);//默认颜色
                else
                    pointmap = HeightColorSchemeFirst(myscalar, Points, polyData, lookupTable, glyphFilter, pointmap, point, 1.0);//根据高度分配颜色范围

                vtkActor.SetMapper(pointmap);
                vtkActor.GetProperty().SetPointSize(SystemSetting.PointSize);
            }

            return vtkActor;
        }

        #region 目标文本
        public static List<vtkTextActor3D> DddText(vtkTextProperty textproperty, vtkTextActor3D textActor, List<vtkTextActor3D> addtext, List<TargetInfo.RadarTargetInfoStruct> textlist)
		{
			bool textShowFlag = SystemSetting.DisplayText;
			if (textShowFlag)
			{
				bool flag = textlist != null;
				if (flag)
				{
					for (int i = 0; i < textlist.Count; i++)
					{
						textActor = vtkTextActor3D.New();
						textproperty = VTKHelper.SetTextProperty(textproperty);
						string text = GetDetectionText(textlist[i]);

						textActor.SetInput(text);
						textActor.SetTextProperty(textproperty);
						textActor.SetPosition(textlist[i].XAxis, textlist[i].YAxis, textlist[i].ZAxis);
						textActor.SetScale(0.03, 0.03, 0.03);
						textActor.RotateX(90.0);
						//textActor.RotateY(315.0);
						//textActor.RotateZ(270.0);
						addtext.Add(textActor);
					}
				}
			}
			return addtext;
		}

		public static string GetDetectionText(TargetInfo.RadarTargetInfoStruct tar)
        {
			StringBuilder text = new StringBuilder();
			if (SystemSetting.Tar_ID)
            {
				text.Append(GetText("ID:", tar.ID.ToString()));
            }
			if (SystemSetting.Tar_X)
			{
                text.Append(GetText("X:", tar.XAxis.ToString()));
			}
			if (SystemSetting.Tar_Y)
			{
                text.Append(GetText("Y:", tar.YAxis.ToString()));
			}
			if (SystemSetting.Tar_Z)
			{
                text.Append(GetText("Z:", tar.ZAxis.ToString()));
			}
			return text.ToString();
        }
        public static string GetDetectionTextH(TargetInfo.RadarTargetInfoStruct tar)
        {
            StringBuilder text = new StringBuilder();
			text.Append(SystemSetting.Tar_ID ? $"ID={tar.ID}" : "");
			text.Append(SystemSetting.Tar_X ? $" X={tar.XAxis:F2}" : "");
			text.Append(SystemSetting.Tar_Y ? $" Y={tar.YAxis:F2}" : "");
			text.Append(SystemSetting.Tar_Z ? $" Z={tar.ZAxis:F2}" : "");
			text.Append(SystemSetting.Tar_V ? $" V={tar.Velocity:F2}" : "");
			text.Append(SystemSetting.Tar_A ? $" A={tar.PAngle:F2}" : "");
			text.Append(SystemSetting.Tar_C ? $" C={tar.Confidence}" : "");
            //string text = $"{(SystemSetting.Tar_ID?$"ID={tar.ID} ":"")}{(SystemSetting.Tar_X ? $" X={tar.XAxis:F3}m " : "")}{(SystemSetting.Tar_Y ? $" Y={tar.YAxis:F3}m " : "")}{(SystemSetting.Tar_Z ? $" Z={tar.ZAxis:F3}m " : "")}{(SystemSetting.Tar_V ? $" V={tar.Velocity:F3}m/s " : "")}{(SystemSetting.Tar_A ? $" A={tar.PAngle:F3}deg " : "")}{(SystemSetting.Tar_C ? $" C={tar.Confidence} " : "")} ";

            return text.ToString().TrimStart().TrimEnd(';');
        }

        private static string GetText(string keyStr ,string valueStr)
        {
            string str = string.Empty;
            bool flag2 = valueStr.Length > 5;
            if (flag2)
            {
                str = valueStr.Substring(0, 4);
                return $"{keyStr}{str}\r\n";
            }
            else
            {
                return $"{keyStr}{valueStr}\r\n";
            }
        }

        public static vtkTextProperty SetTextProperty(vtkTextProperty vtkText)
		{
			vtkText.SetFontSize(50);
			vtkText.SetColor(1.0, 1.0, 1.0);
			vtkText.SetOpacity(1.0);
			vtkText.SetFontFamily(1);
			vtkText.SetJustificationToLeft();
			vtkText.SetVerticalJustificationToCentered();
			vtkText.SetFontFamilyToCourier();
			vtkText.SetBold(1);
			return vtkText;
		}
		#endregion 目标文本

		#region 目标点颜色
		/// <summary>
		/// 根据目标点集合最小值（紫）和最大值（红）渐变颜色
		/// </summary>
		public static vtkPolyDataMapper HeightColorSchemeDefult(vtkFloatArray myscalar, vtkPoints Points, vtkPolyData polyData, vtkLookupTable lookupTable, vtkVertexGlyphFilter glyphFilter, vtkPolyDataMapper pointmap, List<TargetInfo.RadarTargetInfoStruct> pointinfo, double transparency)
		{
			List<TargetInfo.RadarTargetInfoStruct> tarListTemp = null;
			bool flag = pointinfo != null;
			if (flag)
			{
				tarListTemp=pointinfo;
			}
			int num = tarListTemp==null?0:tarListTemp.Count;
			lookupTable.SetNumberOfColors(num);
			//int num2 = 0;
			bool flag2 = tarListTemp != null && tarListTemp.Count != 0;
			if (flag2)
			{
				for (int i = 0; i < tarListTemp.Count; i++)
				{
					Points.InsertNextPoint(tarListTemp[i].XAxis, tarListTemp[i].YAxis, tarListTemp[i].ZAxis);
					//myscalar.InsertTuple1(num2, (double)num2);
					myscalar.InsertNextTuple1(tarListTemp[i].ZAxis);
					//lookupTable.SetTableValue(num2, 0.0, 1.0, 0.0, transparency);
					//num2++;
				}
				lookupTable.SetHueRange(0.67, 0);//红大蓝小
				lookupTable.Build();
				polyData.SetPoints(Points);
				polyData.GetPointData().SetScalars(myscalar);
				glyphFilter.SetInputConnection(polyData.GetProducerPort());
				pointmap.SetInputConnection(glyphFilter.GetOutputPort());
				//pointmap.SetScalarRange(0.0, (double)(num - 1));
				double[] bound = polyData.GetBounds();
				pointmap.SetScalarRange(bound[4], bound[5]);
				pointmap.SetLookupTable(lookupTable);
			}
			return pointmap;
		}

		/// <summary>
		/// 自定义高度匹配颜色 大（红）-》小(紫)
		/// </summary>
        public static vtkPolyDataMapper HeightColorSchemeFirst(vtkFloatArray myscalar, vtkPoints Points, vtkPolyData polyData, vtkLookupTable lookupTable, vtkVertexGlyphFilter glyphFilter, vtkPolyDataMapper pointmap, List<TargetInfo.RadarTargetInfoStruct> pointinfo, double transparency)
        {
            List<TargetInfo.RadarTargetInfoStruct> list = null;
            bool flag = pointinfo != null;
            if (flag)
            {
                list = pointinfo;
            }
			int num = list == null ? 0 : list.Count;
            lookupTable.SetNumberOfColors(num);
            int num2 = 0;
            bool flag2 = list != null && list.Count != 0;
            if (flag2)
            {
                for (int i = 0; i < list.Count; i++)
                {
					Points.InsertNextPoint(list[i].XAxis, list[i].YAxis, list[i].ZAxis);
					myscalar.InsertTuple1(num2, (double)num2);
					double z = list[i].ZAxis;

					if(z > SystemSetting.RedValue)//红
						lookupTable.SetTableValue(num2, 1.0, 0.0, 0.0, transparency);
					else if(z <= SystemSetting.RedValue && z > SystemSetting.OrangeValue)//橙
						lookupTable.SetTableValue(num2, 1.0, 0.6, 0.0, transparency);
					else if (z <= SystemSetting.OrangeValue && z > SystemSetting.YellowValue)//黄
						lookupTable.SetTableValue(num2, 1.0, 1.0, 0.0, transparency);
					else if (z <= SystemSetting.YellowValue && z > SystemSetting.GreenValue)//绿
						lookupTable.SetTableValue(num2, 0.0, 1.0, 0.0, transparency);
					else if (z <= SystemSetting.GreenValue && z > SystemSetting.CyanValue)//青
						lookupTable.SetTableValue(num2, 0.0, 1.0, 1.0, transparency);
					else if (z <= SystemSetting.CyanValue && z > SystemSetting.BlueValue)//蓝
						lookupTable.SetTableValue(num2, 0.0, 0.0, 1.0, transparency);
					else
						lookupTable.SetTableValue(num2, 0.5, 0.0, 0.5, transparency);//紫
                    num2++;

                }
                lookupTable.Build();
                polyData.SetPoints(Points);
                polyData.GetPointData().SetScalars(myscalar);
                glyphFilter.SetInputConnection(polyData.GetProducerPort());
                pointmap.SetInputConnection(glyphFilter.GetOutputPort());
                pointmap.SetScalarRange(0.0, (double)(num - 1));
                pointmap.SetLookupTable(lookupTable);
            }
            return pointmap;
        }

        #endregion 目标点颜色
    }
}
