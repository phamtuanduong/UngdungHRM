   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UngdungHRM.DialogHostControlUngdungHRM.DialogHostControl  5      6    0UngdungHRM.DialogHostControl.dialogHost_Location   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:UngdungHRM.DialogHostControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      �   � RowDefinitions  5   
   �� 5      $��30 �6   �� 5      .+�5   
   �� -   5         ��Name$ checkAdd��5   $    d� 	IsChecked$
 TrueY�6   $y�	Collapsed=�66   �� 5   
    �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��2��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow	   Color#	 [  6R   
   Opacity$	
 .42Q�6�      RenderingBias$ Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� -   5         ��Name$ txtNameControl��5      $��THÊM TÀI KHOẢN��60   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5    $   $��Center=�5!   $   5"      � 5$   
   -   5         �Name$ 
controlAdd��5$   "   $��	15 0 15 0q�6   $��2��66     5'      �� 5(      $��* �6    �� 5)      $
��Auto �6    .+�5,      �   5-      �� 5.      �� 5/      �� 50      �� 51      �� 52      �� 53       � ColumnDefinitions 56      �� 57      �� 58      .+�5;      �� $��Tên *��6   $��Center=�5<      $��0 15 0 0q�5=      $��14(�5>      �� 5?      $��Quốc gia *��6   $��1��6.   $��0 15 0 0q�5@      $��14(�5A      �� 5C      $��Quận/Huyện��6   $��2��6.   $��0 15 0 0q�5D      $��14(�5E      �� 5G      $��Thành phố��6   $��3��6-   $��0 15 0 0q�5H      $��14(�5I      �� 5K      $��Địa chỉ��6   $��4��6+   $��0 15 0 0q�5L      $��14(�5N      y�5M      �� *	IsChecked+ �� ElementName$ Check��   BooleanToVisibilityConverter �� 	Converter# [ 5N      �� 5P      $��Điện thoại��6   $��5��6.   $��0 15 0 0q�5Q      $��14(�5S      y�5R      �� *	IsChecked+$ Check��# [ 5S      �� 5U      -   5         ��Name$ txtTen��5]       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5U      $��1��5V      $��0��5W      $��39��5X      
�������$��5 15 5 5q�5Z       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5\      ��5^      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�{�5_      �� *	IsChecked+$ checkAdd��.��6O   5`      �� 5b      -   5         ��Name$ 	cbQuocgia��5i      $��	15 10 0 0q�5b      $��1��5c       �� 
IsEditable . $��1��5e      $��39��5f      
�������$��1q�5h      $��3 15 3 5q�5j       �� Text 5k      �� *	Country+$ PropertyChanged=�{�5l      �� *	IsChecked+$ checkAdd��5n      �� 5p      #��[ 6   $��1��5q      $��2��5r      $��39��5s      
�������$��5 15 5 5q�5u       . $
 Wrap=�5w      ��5x      �� *State+$ PropertyChanged=�{�5y      �� *	IsChecked+$ checkAdd��.��6O   5z      �� 5|      #��[ 6   $��1��5}      $��3��5~      $��39��5      
�������$��5 15 5 5q�5�       . $
 Wrap=�5�      ��5�      �� *City+$ PropertyChanged=�{�5�      �� *	IsChecked+$ checkAdd��.��6O   5�      �� 5�      #��[ 6   $��1��5�      $��4��5�      $��39��5�      
�������$��5 15 5 5q�5�       . $
 Wrap=�5�      ��5�      �� *	Address+$ PropertyChanged=�{�5�      �� *	IsChecked+$ checkAdd��.��6O   5�      �� 5�      #��[ 6   $��1��5�      $��5��5�      $��39��5�      
�������$��5 15 5 5q�5�       . $
 Wrap=�5�      ��5�      �� *Phone+$ PropertyChanged=�{�5�      �� *	IsChecked+$ checkAdd��.��6O   5�      5�      �� 5�      $��1��6     MaterialDesignDarkSeparator#��[ 6#   $	��0 5q�6X   $��1��6e   $	��Top=�6r   �� 5�       �� Orientation$ 
Horizontal=�6   $��1��62   $��	0 10 0 10q�5�      $��Center=�5�      .+�5�      �� -   5         ��Name$ btnSave��5�       # MaterialDesignFlatLightBgButton#��[ 6*   ���	#FF086912
�������$��0 0 10 0q�5�      $	��120��5�      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�      $	��Top=�6C   .��6[   
LƯU LẠI5�      �� 5�      -   5        #��[ 5�      ���	#FF4D4D4D
�������$��0 0 10 0q�5�      $	��120��5�      
������ $ 15��5�      .��5�   .   
HỦY BỎ5�      5�      5�      5�      5�      