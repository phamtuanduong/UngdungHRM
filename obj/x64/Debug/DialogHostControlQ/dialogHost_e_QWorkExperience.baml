   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:UngdungHRM.DialogHostControlQUngdungHRM.DialogHostControlQ  5      @    :UngdungHRM.DialogHostControlQ.dialogHost_e_QWorkExperience   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:UngdungHRM.DialogHostControlQ     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��3��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R      Opacity$	 .42Q�6�   	   RenderingBias$	 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� $#��THÊM LIÊN HỆ KHẨN CẤP��6   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5      � 5    
   $��	15 0 15 0q�6   $��1��6"     5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      
 � ColumnDefinitions
 5(      �� 5)      $
��Auto �6#   �� 5*      .+�5-      �� $��
Công ty *��6   $��Center=�5.      $��0 5 0 0q�5/      $��14(�50      �� 52      $��Chức vụ *��6   $��Center=�53      $��0 5 0 0q�54      $��14(�55      $��1��56       �� 58      $��Ngày bắt đầu��6   $��Center=�59      $��0 5 10 0q�5:      $��14(�5;      $��2��5<       �� 5>      $��Ngày kết thúc��6   $��Center=�5?      $��0 5 10 0q�5@      $��14(�5A      $��3��5B       �� 5D      $��Bình luận��6   $��Center=�5E      $��0 5 10 0q�5F      $��14(�5G      $��4��5H       �� 5L      -   5         ��Name$ txtTen��5T       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5L      $��1��5M      $��0��5N      $��39��5O      
�������$��5 15 5 5q�5Q       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5S      ��5U      �� *	Company+ �� UpdateSourceTrigger$ PropertyChanged=�{�5V      �� *	IsChecked+ �� ElementName$ checkAdd��.��6O   5W      �� 5Y      #��[ 6   $��1��5Z      $��1��5[      $��39��5\      
�������$��5 15 5 5q�5^       . $
 Wrap=�5`      ��5a      �� *
JobTitle+$ PropertyChanged=�{�5b      �� *	IsChecked+$ checkAdd��.��6O   5c      (  "System.Windows.Controls.DatePicker  5e      -   5          Name$ 	dateStart��5n      $��1��5g      $��2��5h      $��40��5i      $��5 15 5 5q�5j      $��1q�5k      $��5 0 5 0q�5m      
�������{�5f      �� *	IsChecked+$ 	checkEdit��5p        5r      -   5        $ dateEnd��5y      $��1��5t      $��3��5u      $��40��5v      $��5 15 5 5q�5w      $��1q�5x      $��5 0 5 0q�5z      
�������{�5s      �� *	IsChecked+$ 	checkEdit��5}      �� 5      #��[ 6   $��1��5�      $��4��5�      
�������$��5 10 0 5q�5�      $	��220��5�      $��60��5�      $
��Left=�5�      ��5�      �� *	Comment+$ PropertyChanged=�.��5�   9   5�      5�      �� 5�   
   $��1��6     MaterialDesignDarkSeparator#��[ 6   $	��0 5q�6T   $��2��6a   $	��Top=�6n   �� 5�   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��
10 10 0 10q�5�      $
��Left=�5�      .+�5�      �� -   5         ��Name$ 
btnSaveCur��5�       # MaterialDesignFlatLightBgButton#��[ 5�      ���	#FF086912
�������$��0 0 10 0q�5�      $	��120��5�      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�      .��6C   
LƯU LẠI5�      �� 5�      -   5        #��[ 5�      ���	#FF4D4D4D
�������$��0 0 10 0q�5�      $	��120��5�      
������ $ 15��5�      .��5�   /   
HỦY BỎ5�      5�      5�      5�      