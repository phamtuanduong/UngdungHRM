   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:UngdungHRM.DialogHostControlQUngdungHRM.DialogHostControlQ  5      4    .UngdungHRM.DialogHostControlQ.dialogHostReport   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:UngdungHRM.DialogHostControlQ     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      $	��400��5      .��5
      �   � RowDefinitions  5   
   �� 5      $��30 �6   �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��3��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R      Opacity$	 .42Q�6�   	   RenderingBias$	 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� $-��'XUẤT BÁO CÁO THÔNG TIN NHÂN VIÊN��6   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5      � 5!   
   $��	15 0 15 0q�6   $��1��6"   .+�5"      &   System.Windows.Controls.DataGrid  -   5        
  Name$

 data��5"      $��1��6%      AutoGenerateColumns .     HeadersVisibility$	 All=�5$      
������    CanUserAddRows .  $��Stretch=�5(      $��Stretch=�5)         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5*      $	��400��5+      ��5&      �� *list+   Columns 5-      4  .System.Windows.Controls.DataGridCheckBoxColumn  5.       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5/   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 50   -   ,  &System.Windows.Controls.DataGridColumn   Width$ 50 51   -      Binding 5.   -   �� *
IsSelect+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Header 52      �� 53      
������ ._�54   "   �� -   5         ��Name$ checkAll��54   +    d� 	IsChecked 6>   �� *IsAllSelect+56         HeaderStyle 58      �� 59       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$    & "MaterialDesignDataGridColumnHeader �� BasedOn# [ 5:   $   .�5;   "   ��  �� Property � �� �� Value$ Center=�6O   5<      5>      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5@      $ Nhân viên��5B         
IsReadOnly .  5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5D       5A      �� *
FullName+ 5E      �� 5F      "  5G      # [ 5H      .�5I   "   ��  � ��$
 Left=�5K      �� 5L   "    � �� 5N   &   �� 5O   *   .R�5P   .   �� $
��Wrap=�5Q       �� TextAlignment$
 Left=�5S      ��5R      �� 5S      5T   +   5V   #   5W       5Y      �� 5Z      " ��5[       ) %MaterialDesignDataGridTextColumnStyle# [ 5\      .�5]   "   ��  � ��$
 Left=�5_      5`      5b      5e      5f      �� 5h   
   $��1��6     MaterialDesignDarkSeparator#��[ 6   $	��0 5q�6T   $��2��6a   $	��Top=�6n   �� 5i   
     �� Orientation$  
Horizontal=�6   $��2��6.   $��
10 10 0 10q�5j      $
��Left=�5k      .+�5l      �� -   5        ! ��Name$! 
btnSaveCur��5r       # MaterialDesignFlatLightBgButton#��[ 5l      ���	#FF086912
�������$��0 0 10 0q�5o      $	��120��5p      
������ +	  %MaterialDesignThemes.Wpf.ButtonAssist" 	  CornerRadius$" 15��5t      .��6C   XUẤT5v      �� 5x      -   5        #��[ 5x      ���	#FF4D4D4D
�������$��0 0 10 0q�5{      $	��120��5|      
������ $" 15��5~      .��5   /   
HỦY BỎ5�      5�      5�      5�      