   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:UngdungHRM.DialogHostControlQUngdungHRM.DialogHostControlQ  5      ;    5UngdungHRM.DialogHostControlQ.dialogHost_e_QLanguages   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:UngdungHRM.DialogHostControlQ     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��3��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R      Opacity$	 .42Q�6�   	   RenderingBias$	 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� $��THÊM NGÔN NGỮ��6   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5      � 5    
   $��	15 0 15 0q�6   $��1��6"     5!      �� 5"      �� 5#      �� 5$      �� 5%      
 � ColumnDefinitions
 5'      �� 5(      $
��Auto �6#   �� 5)      .+�5,      �� $��Ngôn ngữ *��6   $��Center=�5-      $��0 5 0 0q�5.      $��14(�5/      �� 51      $��Kỹ năng *��6   $��Center=�52      $��0 5 0 0q�53      $��14(�54      $��1��55       �� 57      $��Trình độ��6   $��Center=�58      $��0 5 10 0q�59      $��14(�5:      $��2��5;       �� 5=      $��Bình luận��6   $��Center=�5>      $��0 5 10 0q�5?      $��14(�5@      $��4��5A       �� 5E      -   5         ��Name$ cbChucVu��5M      $��1��5G      $��0��5H      
�������   MaterialDesignFilledComboBox#��[ 5J      $��1q�5K      $��3 5 3 5q�5L       �� DisplayMemberPath$
 Name��5N       �� SelectedValuePath$
 Name��5O      {�5F      �� *	IsChecked+ �� ElementName$ 	checkEdit�� �� SelectedValue 5P      �� *
Language+ �� Text 5Q      �� *
Language+ �� UpdateSourceTrigger$ PropertyChanged=��� 5T      -   5        $ cbKyNang��5\      $��1��5V      $��1��5W      
�������#��[ 5Y      $��1q�5Z      $��3 5 3 5q�5[      {�5U      �� *	IsChecked+$ 	checkEdit�� 5]      �� *	Fluency+ 5^      �� *	Fluency+$ PropertyChanged=��� 5a      -   5        $ 	cbTrinhDo��5i      $��1��5c      $��2��5d      
�������#��[ 5f      $��1q�5g      $��3 5 3 5q�5h      {�5b      �� *	IsChecked+$ 	checkEdit�� 5j      �� *
Competency+ 5k      �� *
Competency+$ PropertyChanged=�5m      �� 5o       * &MaterialDesignOutlinedTextFieldTextBox#��[ 6   $��1��5p      $��4��5q      
�������$��5 10 0 5q�5s      $	��220��5t      $��60��5u      $
��Left=�5w      ��5v      �� *
Comments+$ PropertyChanged=�.��5w   9   5y      5{      �� 5}   
   $��1��6     MaterialDesignDarkSeparator#��[ 6   $	��0 5q�6T   $��2��6a   $	��Top=�6n   �� 5~   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��
10 10 0 10q�5      $
��Left=�5�      .+�5�      �� -   5         ��Name$ 
btnSaveCur��5�       # MaterialDesignFlatLightBgButton#��[ 5�      ���	#FF086912
�������$��0 0 10 0q�5�      $	��120��5�      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�      .��6C   
LƯU LẠI5�      �� 5�      -   5        #��[ 5�      ���	#FF4D4D4D
�������$��0 0 10 0q�5�      $	��120��5�      
������ $ 15��5�      .��5�   /   
HỦY BỎ5�      5�      5�      5�      