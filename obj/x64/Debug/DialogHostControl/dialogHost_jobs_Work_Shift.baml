   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UngdungHRM.DialogHostControlUngdungHRM.DialogHostControl  5      =    7UngdungHRM.DialogHostControl.dialogHost_jobs_Work_Shift   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:UngdungHRM.DialogHostControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��30 �6   �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��2��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R      Opacity$	 .42Q�6�   	   RenderingBias$	 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� -   5        
 ��Name$
 txtNameControl��5      $&�� THÊM TÊN VỊ TRÍ VIỆC LÀM��60   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5      � 5   
   -   5         �Name$ 
controlAdd��5   "   $��	15 0 15 0q�6   $��2��66     5"      �� 5#      $��* �6    �� 5$      $
��Auto �6    .+�5'      �   5)      �� 5*      $
��Auto �6$   �� 5+      $
��Auto �6$    � ColumnDefinitions 5-      �� 5.      $
��Auto �6'   �� 5/      .+�52      �� $��Tên *��6   $��Center=�53      $��0 5 0 0q�54      $��14(�55      �� 56      $��Giờ làm việc *��6   $��1��57      $��Center=�58      $��0 5 0 0q�59      $��14(�5:      �� 5<      -   5        $��txtTen��5A       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5<      $��1��5=      
�������$��20 5 0 0q�5?      $	��220��5@      $
��Left=�5B      .��65   5D      �� 5F       �� Orientation$ 
Horizontal=�6   $��1��5G      $��1��6*   $��20 0 0 0q�6:   .+�5H      �� $
��Từ��6    $��Center=�6*   �� 5I      -   5        $��cbFrom��5I      $��	10 0 20 0q�6-   6@   �� 5K      $��Đến��6    $��Center=�6+   �� 5L      -   5        $
��cbTo��5L      $��	10 0 20 0q�6+   5M      �� 5N      $��Thời lượng��6    $��Center=�62   �� 5O      -   5        $��txtTime��5U      #��[ 5O      $��1��5P      
�������$��5 5 0 0q�5R      $��90��5S      {�.  $��0��5V      5W      5Z      �� 5\      $��1��6     MaterialDesignDarkSeparator#��[ 6#   $	��0 5q�6X   $��1��6e   $	��Top=�6r   �� 5^      $ 
Horizontal=�6   $��1��62   $��	0 10 0 10q�5_      $
��Left=�5`      .+�5a      �� -   5         ��Name$ btnSave��5a       # MaterialDesignFlatLightBgButton#��[ 6*   ���	#FF086912
�������$��0 0 10 0q�5d      $	��120��5e      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5h      .��6C   
LƯU LẠI5j      �� 5l      -   5        #��[ 5l      ���	#FF4D4D4D
�������$��0 0 10 0q�5o      $	��120��5p      
������ $ 15��5r      .��5s   .   
HỦY BỎ5u      5v      5w      5x      5y      