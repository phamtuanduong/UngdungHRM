   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UngdungHRM.DialogHostControlUngdungHRM.DialogHostControl  5      7    1UngdungHRM.DialogHostControl.dialogHost_structure   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:UngdungHRM.DialogHostControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      �   � RowDefinitions  5   
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
��Auto �6    .+�5,      �   5-      �� 5.      $
��Auto �6$   �� 5/      $
��Auto �6$   �� 50      $
��Auto �6$    � ColumnDefinitions 53      �� 54      $
��Auto �6'   �� 55      .+�58      �� $��ID đơn vị��6   $��Center=�59      $��0 15 0 0q�5:      $��14(�5;      �� 5<      $��Tên *��6   $��1��6)   $��0 15 0 0q�5=      $��14(�5>      $��Center=�5?      �� 5A      $��Mô tả��6   $��2��6)   $��0 15 0 0q�5B      $��14(�5C      $��Center=�5D      �� 5F      -   5         ��Name$ txtTen��5L       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5F      $��1��5G      $��1��5H      $��39��5I      
�������$��5 15 5 5q�5K       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5N      {�5O      �� *	IsChecked+ �� ElementName$ checkAdd��.��6O   5P      �� 5R      -   5        $ 	txtUnitID��5Y      #��[ 5R      $��1��5S      $��0��5T      $��39��5U      
�������$��5 15 5 5q�5W       . $
 Wrap=�5Z      {�5]      �� *	IsChecked+$ checkAdd��.��6O   5^      �� 5b      -   5        $ txtMoTa��5j      #��[ 5b      $��1��5c      $��3��5d      $��39��5e      
�������$��5 15 5 5q�5g       . $
 Wrap=�5i      {�5l      �� *	IsChecked+$ checkAdd��.��6O   5m      5o      �� 5q      $��1��6     MaterialDesignDarkSeparator#��[ 6#   $	��0 5q�6X   $��1��6e   $	��Top=�6r   �� 5s       �� Orientation$ 
Horizontal=�6   $��1��62   $��	0 10 0 10q�5t      $��Center=�5u      .+�5v      �� -   5         ��Name$ btnSave��5v       # MaterialDesignFlatLightBgButton#��[ 6*   ���	#FF086912
�������$��0 0 10 0q�5y      $	��120��5z      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5}      $	��Top=�6C   .��6[   
LƯU LẠI5      �� 5�      -   5        #��[ 5�      ���	#FF4D4D4D
�������$��0 0 10 0q�5�      $	��120��5�      
������ $ 15��5�      .��5�   .   
HỦY BỎ5�      5�      5�      5�      5�      