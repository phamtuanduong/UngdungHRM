   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UngdungHRM.DialogHostControlUngdungHRM.DialogHostControl  5      8    2UngdungHRM.DialogHostControl.dialogHost_report_add   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:UngdungHRM.DialogHostControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��30 �6   �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��2��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R      Opacity$	 .42Q�6�   	   RenderingBias$	 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� -   5        
 ��Name$
 txtNameControl��5      $��THÊM BÁO CÁO MỚI��60   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5      � 5   
   -   5         �Name$ 
controlAdd��5   "   $��	15 0 15 0q�6   $��2��66     5"      �� 5#      $��* �6    �� 5$      $
��Auto �6    .+�5'      �   5)      �� 5*      $
��Auto �6$   �� 5+      $
��Auto �6$   �� 5,      $
��Auto �6$   �� 5-      $
��Auto �6$   �� 5.      $
��Auto �6$    � ColumnDefinitions 50      �� 51      $
��Auto �6'   �� 52      .+�55      �� $��Tên báo cáo *��6   $��Center=�56      $��0 5 0 0q�57      $��14(�58      �� 59      $��Chọn tiêu chí��6   $��1��5:      $��0 15 0 0q�5;      $��14(�5<      �� 5>      $��Tiêu chí đã chọn��6   $��2��5?      $��0 15 0 0q�5@      $��14(�5A      �� 5C      $��Trường hiển thị��6   $��3��5D      $��0 15 0 0q�5E      $��14(�5F      �� 5H      -   5        $��txtTen��5M       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5H      $��1��5I      
�������$��20 5 0 0q�5K      $	��220��5L      $
��Left=�5N      .��65   5P      �� 5R      -   5         ��Name$ 	cbTieuChi��5T      $��1��5R      $��1��6(   $��
20 10 60 0q�5U       �� DisplayMemberPath$ String��5V      
�������$��1q�5X         MaterialDesignFilledComboBox#��[ 5Y      ��5S      �� 5[      �� 5]      -   5        $��1��5]      $��1��6&   $��Right=�5^       & "MaterialDesignIconForegroundButton#��[ 5`      .��5a      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Plus=�6.   5b      �� 5d      -   5         ��Name$ 
lsbTieuChi��5i      $��2��5e      $��1��5f      $	��100��5g      $��0 15 0 0q�5h      $	��150��5j      ��5d      �� ��5k      �� 5l      .R�5m      ��  �� Orientation$ 
Horizontal=�6)   
 � Tag 5n   )   �� *Tag+.+�5o   "   �� -   5        $��X��5o   ,   
���  ��$��Center=�5r   ,   $��15(�5s   ,    � Cursor$
 Hand��5t   ,    5p   ,   �� *ID+��5v   &   �� 5w   *    �� 
TargetType" ��60    �� Triggers 5x   .   P� 5y   2    P� Property �@J�IsMouseOver P� Value . . �5z   6   ��  �� Property � �� �� Value$ 	Underline{�6b   5{   3   5}   +   5   #   �� 5�   "   $��10 0 0 0q�5�   ,   $��Center=�5�   ,   ��5�   ,   �� *Name+5�   #   �� 5�   "   -   5        $��10 0 0 0q�5�   +   $	��100��5�   +   ��5�   +   �� *List+ 5�   +   �� *ID+ �� Text 5�   +   �� *Str+ �� SelectedValue 5�   +   �� *Str+5�   #   5�      5�      5�      �� 5�      -	   5        $ cbTruong��5�      $��3��5�      $��1��6(   $��
20 10 60 0q�5�      $ String��5�      
�������$��1q�5�      #��[ 5�      ��5�      �� 5�      �� 5�      -
   5        $��3��5�      $��1��6&   $��Right=�5�      #��[ 5�      .��5�        $
 Plus=�6.   5�      �� 5�      -   5        $ 	lsbTruong��5�      $��4��5�      $��1��5�      $	��100��5�      $��0 15 0 0q�5�      $	��150��5�      ��5�      �� ��5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)    5�   )   �� *Tag+.+�5�   "   �� -   5        
���  ��$��Center=�5�   ,   $��15(�5�   ,   $
 Hand��5�   ,   ��5�   ,   �� *Delete+ 5�   ,   �� *ID+��5�   &   �� 5�   *   " ��60    5�   .   P� 5�   2    �@J�IsMouseOver . . �5�   6   ��  � ��$ 	Underline{�6b   5�   3   5�   +   5�   #   �� 5�   "   $��10 0 0 0q�5�   ,   $��Center=�5�   ,   ��5�   ,   �� *Name+5�   #   5�      5�      5�      5�      �� 5�      $��1��6     MaterialDesignDarkSeparator#��[ 6#   $	��0 5q�6X   $��1��6e   $	��Top=�6r   �� 5�      $ 
Horizontal=�6   $��1��62   $��	0 10 0 10q�5�      $
��Left=�5�      .+�5�      �� -   5         ��Name$ btnSave��5�       # MaterialDesignFlatLightBgButton#��[ 6*   ���	#FF086912
�������$��0 0 10 0q�5�      $	��120��5�      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�      .��6C   
LƯU LẠI5�      �� 5�      -   5        #��[ 5�      ���	#FF4D4D4D
�������$��0 0 10 0q�5�      $	��120��5�      
������ $ 15��5�      .��5�   .   
HỦY BỎ5�      5�      5�      5�      5�      