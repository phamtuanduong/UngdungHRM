   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UngdungHRM.DialogHostControlUngdungHRM.DialogHostControl  5      3    -UngdungHRM.DialogHostControl.dialogHost_e_job   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:UngdungHRM.DialogHostControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��3��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R      Opacity$	 .42Q�6�   	   RenderingBias$	 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� $#��THÊM LIÊN HỆ KHẨN CẤP��6   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5      � 5    
   $��	15 0 15 0q�6   $��1��6"     5!      �� 5"      �� 5#      �� 5$      
 � ColumnDefinitions
 5&      �� 5'      $
��Auto �6#   �� 5(      .+�5+      �� $��Lý do *��6   $��Center=�5,      $��0 5 0 0q�5-      $��14(�5.      �� 50      $��Ngày *��6   $��Center=�51      $��0 5 0 0q�52      $��14(�53      $��1��54       �� 56      $��Ghi chú��6   $��Center=�57      $��0 5 10 0q�58      $��14(�59      $��2��5:       �� 5>      -   5         ��Name$ cbChucVu��5F      $��1��5@      $��0��5A      
�������   MaterialDesignFilledComboBox#��[ 5C      $��1q�5D      $��3 5 3 5q�5E      {�5?      �� *	IsChecked+ �� ElementName$ 	checkEdit�� �� SelectedValue 5G      �� *Reason+ �� Text 5H      �� *Reason+ �� UpdateSourceTrigger$ PropertyChanged=�(  "System.Windows.Controls.DatePicker  5K      $��1��5M      $��1��5N      $��40��5O      $��5 15 5 5q�5P      $��1q�5Q      $��5 0 5 0q�5T      
�������{�5L      �� *	IsChecked+$ 	checkEdit��   SelectedDate 5R      �� *Date+$ PropertyChanged=�   Text 5S      �� *Date+5W      �� 5Y       * &MaterialDesignOutlinedTextFieldTextBox#��[ 6   $��1��5Z      $��2��5[      
�������$��5 10 0 5q�5]      $	��220��5^      $��60��5_      $
��Left=�5a      ��5`      �� *Note+$ PropertyChanged=�.��5a   9   5c      5e      �� 5g   
   $��1��6     MaterialDesignDarkSeparator#��[ 6   $	��0 5q�6T   $��2��6a   $	��Top=�6n   �� 5h   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��
10 10 0 10q�5i      $
��Left=�5j      .+�5k      �� -   5         ��Name$ 
btnSaveCur��5q       # MaterialDesignFlatLightBgButton#��[ 5k      ���	#FF086912
�������$��0 0 10 0q�5n      $	��120��5o      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5s      .��6C   
LƯU LẠI5u      �� 5w      -   5        #��[ 5w      ���	#FF4D4D4D
�������$��0 0 10 0q�5z      $	��120��5{      
������ $ 15��5}      .��5~   /   
HỦY BỎ5�      5�      5�      5�      