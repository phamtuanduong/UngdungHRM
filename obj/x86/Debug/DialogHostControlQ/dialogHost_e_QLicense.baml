   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:UngdungHRM.DialogHostControlQUngdungHRM.DialogHostControlQ  5      9    3UngdungHRM.DialogHostControlQ.dialogHost_e_QLicense   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:UngdungHRM.DialogHostControlQ     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��3��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R      Opacity$	 .42Q�6�   	   RenderingBias$	 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� $#��THÊM LIÊN HỆ KHẨN CẤP��6   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5      � 5    
   $��	15 0 15 0q�6   $��1��6"     5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      
 � ColumnDefinitions
 5(      �� 5)      $
��Auto �6#   �� 5*      .+�5-      �� $��Tên bằng *��6   $��Center=�5.      $��0 5 0 0q�5/      $��14(�50      �� 52      $��Ngày bắt đầu��6   $��Center=�53      $��0 5 10 0q�54      $��14(�55      $��2��56       �� 58      $��Ngày kết thúc��6   $��Center=�59      $��0 5 10 0q�5:      $��14(�5;      $��3��5<       �� 5@      -   5         ��Name$ cbChucVu��5H      $��1��5B      $��0��5C      
�������   MaterialDesignFilledComboBox#��[ 5E      $��1q�5F      $��3 5 3 5q�5G       �� SelectedValuePath$
 Name��5J       �� DisplayMemberPath$
 Name��5K      {�5A      �� *	IsChecked+ �� ElementName$ 	checkEdit�� �� SelectedValue 5I      �� *LicenseType+ �� Text 5L      �� *LicenseType+ �� UpdateSourceTrigger$ PropertyChanged=�(  "System.Windows.Controls.DatePicker  5O      -   5          Name$ 	dateStart��5X      $��1��5Q      $��2��5R      $��40��5S      $��5 15 5 5q�5T      $��1q�5U      $��5 0 5 0q�5W      
�������{�5P      �� *	IsChecked+$ 	checkEdit��5Z        5\      -   5        $ dateEnd��5c      $��1��5^      $��3��5_      $��40��5`      $��5 15 5 5q�5a      $��1q�5b      $��5 0 5 0q�5d      
�������{�5]      �� *	IsChecked+$ 	checkEdit��5g      5i      �� 5k   
   $��1��6     MaterialDesignDarkSeparator#��[ 6   $	��0 5q�6T   $��2��6a   $	��Top=�6n   �� 5l   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��
10 10 0 10q�5m      $
��Left=�5n      .+�5o      �� -   5         ��Name$ 
btnSaveCur��5u       # MaterialDesignFlatLightBgButton#��[ 5o      ���	#FF086912
�������$��0 0 10 0q�5r      $	��120��5s      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5w      .��6C   
LƯU LẠI5y      �� 5{      -   5        #��[ 5{      ���	#FF4D4D4D
�������$��0 0 10 0q�5~      $	��120��5      
������ $ 15��5�      .��5�   /   
HỦY BỎ5�      5�      5�      5�      