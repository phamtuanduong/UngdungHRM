   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UngdungHRM.DialogHostControlUngdungHRM.DialogHostControl  5      9    3UngdungHRM.DialogHostControl.dialogHost_userAccount   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:UngdungHRM.DialogHostControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      �   � RowDefinitions  5   
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
��Auto �6    .+�5,      �   5-      �� 5.      �� 5/      �� 50      �� 51      �� 52      $
��Auto �6$   �� 53      $
��Auto �6$   �� 54      $
��Auto �6$    � ColumnDefinitions 57      �� 58      �� 59      .+�5<      �� $��Vai trò người dùng *��6   $��Center=�5=      $��0 15 0 0q�5>      $��14(�5?      �� 5@      $��Tên nhân viên *��6   $��1��63   $��0 15 0 0q�5A      $��14(�5B      �� 5D      $��Tên tài khoản *��6   $��2��63   $��0 15 0 0q�5E      $��14(�5F      �� 5H      $��Trạng thái *��6   $��3��60   $��0 15 0 0q�5I      $��14(�5J      �� 5L      $��Mật khẩu *��6   $��5��6.   $��0 15 0 0q�5M      $��14(�5O      y�5N      �� *	IsChecked+ �� ElementName$ Check��   BooleanToVisibilityConverter �� 	Converter# [ 5O      �� 5Q      $!��Nhập lại mật khẩu *��6   $��6��67   $��0 15 0 0q�5R      $��14(�5T      y�5S      �� *	IsChecked+$ Check��# [ 5T      �� 5V      $��	15 10 0 0q�6   $��1��5W      $��39��5X      $	��200��5Y      
�������$��1q�5[      $��3 15 3 5q�5\       �� Text 5]      �� *Role+ �� UpdateSourceTrigger$ PropertyChanged=�{�5^      �� *	IsChecked+$ checkAdd��.@�5_      �� .��6#   ESS5a      �� 5b      .��6#   Admin5d      5e      �� 5g      -   5         ��Name$ 
cbNhanVien��5l      $��	15 10 0 0q�5g      $��1��5h       �� 
IsEditable . $��1��5j      $��39��5k      
�������$��1q�5n      $��3 15 3 5q�5o       5p      �� *Displayname+$ PropertyChanged=�{�5q      �� *	IsChecked+$ checkAdd��5s      �� 5u      -   5         ��Name$ txtTen��5}       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5u      $��1��5v      $��2��5w      $��39��5x      
�������$��5 15 5 5q�5z       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5|      ��5~      �� *
Username+$ PropertyChanged=�{�5      �� *	IsChecked+$ checkAdd��.��6O   5�      �� 5�      -   5        $ cbTrangThai��5�      $��	15 10 0 0q�5�      $��1��5�      $��3��5�      
�������$��1q�5�      $��3 15 3 5q�5�      $��39��5�      {�5�      �� *	IsChecked+$ checkAdd��.@�5�      �� .��6#   Bật5�      �� 5�      .��6#   Tắt5�      5�      G� 5�      -   5         G�Name$ txtPass��5�   "   $��5��5�      $��1��6+   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5�   "   $��0q�6_   $��5 15 5 5q�5�   "   $��14(�5�   "   $��39��5�      
������� 2 .MaterialDesignOutlinedPasswordFieldPasswordBox#��[ 5�      y�5�      �� *	IsChecked+$ Check��# [ 5�      G� 5�      -   5        $ txtPassAgain��5�   "   $��6��5�      $��1��6+   $ Hidden=�5�   "   $��0q�6_   $��5 15 5 5q�5�   "   $��14(�5�   "   $��39��5�      
�������#��[ 5�      y�5�      �� *	IsChecked+$ Check��# [ 5�      �� 5�      -	   5         ��Name$ 
changePass��5�       �� Orientation$ 
Horizontal=�5�      $y�	Collapsed=�5�      $��4��5�      $��2��5�      .+�5�      �� $��Thay đổi mật khẩu��6    $��1��69   $��	0 15 0 10q�5�      $��14(�5�      �� 5�      -
   5        $ Check��5�      $
 TrueY�5�      $��
73 15 0 10q�60   {�5�      �� *	IsChecked+$ checkAdd��5�      5�      �� 5�      $��1��6     MaterialDesignDarkSeparator#��[ 6#   $	��0 5q�6X   $��1��6e   $	��Top=�6r   �� 5�      $ 
Horizontal=�6   $��1��62   $��	0 10 0 10q�5�      $��Center=�5�      .+�5�      �� -   5         ��Name$ btnSave��5�       # MaterialDesignFlatLightBgButton#��[ 6*   ���	#FF086912
�������$��0 0 10 0q�5�      $	��120��5�      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�      $	��Top=�6C   .��6[   
LƯU LẠI5�      �� 5�      -   5        #��[ 5�      ���	#FF4D4D4D
�������$��0 0 10 0q�5�      $	��120��5�      
������ $ 15��5�      .��5�   .   
HỦY BỎ5�      5�      5�      5�      5�      