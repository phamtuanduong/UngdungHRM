   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UngdungHRM.DialogHostControlUngdungHRM.DialogHostControl  5      A    ;UngdungHRM.DialogHostControl.dialogHost_jobs_Job_Categories   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:UngdungHRM.DialogHostControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
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
��Auto �6    .+�5'      �  � ColumnDefinitions 5)      �� 5*      �� 5+      .+�5.      �� $��Tên *��6   $��Center=�5/      $��0 5 0 0q�50      $��14(�51      �� 53      -   5        $��txtTen��58       * &MaterialDesignOutlinedTextFieldTextBox#��[ 53      $��1��54      
�������$��5 5 0 0q�56      $	��220��57      .��58   (   5:      5=      �� 5?      $��1��6     MaterialDesignDarkSeparator#��[ 6#   $	��0 5q�6X   $��1��6e   $	��Top=�6r   �� 5A       �� Orientation$ 
Horizontal=�6   $��1��62   $��	0 10 0 10q�5B      $��Center=�5C      .+�5D      �� -   5         ��Name$ btnSave��5D       # MaterialDesignFlatLightBgButton#��[ 6*   ���	#FF086912
�������$��0 0 10 0q�5G      $	��120��5H      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5K      .��6C   
LƯU LẠI5M      �� 5O      -   5        #��[ 5O      ���	#FF4D4D4D
�������$��0 0 10 0q�5R      $	��120��5S      
������ $ 15��5U      .��5V   .   
HỦY BỎ5X      5Y      5Z      5[      5\      