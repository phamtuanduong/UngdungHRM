   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UngdungHRM.NewControlsUngdungHRM.NewControls  5      0    *UngdungHRM.NewControls.quantrivieclam_item   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:UngdungHRM.NewControls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $��0 10 0 0q�6   $��1��6     � ColumnDefinitions  5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   
�������._�5      �� .+�5      �� -   5         #  MaterialDesignFlatLightBgButton#��[  5      ���	#FF94A4A8
������ 
�������+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5   !   .��6O   Tên vị trí việc làm5      �� 5      -   5        #��[  5      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�5   !   $	��180��5    !   $ 15��5"   !   .��6O   Lương theo công việc5$      �� 5&      -   5        #��[  5&      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�5*   !   $ 15��5,   !   .��6O   Dạng hợp đồng5.      �� 50      -   5        #��[  50      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�54   !   $ 15��56   !   .��6O   Loại vị trí việc làm58      �� 5:      -   5        #��[  5:      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�5>   !   $ 15��5@   !   .��6O   Ca làm việc5B      5D       J� Effect 5F      3  -System.Windows.Media.Effects.DropShadowEffect  5G         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B     MaterialDesignShadow   Color# [ 6R   	   Opacity$		 .42Q�6�   
   RenderingBias$
 Performance=�6�   5I      )  #MaterialDesignThemes.Wpf.DialogHost  5K   
   -   5          Name$ 
dialogHost��5L   %   $��1��5K   %   $��10 0 0 0q�65      DialogContent 5M      � 5N      -   5         �Name$ dialogHostControl��5N      .��5P      �  � RowDefinitions 5Q      �� 5R      $��30 �6$   �� 5S      .+�5V      �� $ 10��6   $ 10q�6+   
�������$��2��5W       5X        5Y      $ 5Q�6+   $ 1Q�6:   $	 270Q�6J   # [ 6Z   $		 .42Q�6�   $
 Performance=�6�   5[      �� 5]      ���#EFEFEF$ 	10 10 0 0��5^      ._�5_      �� -   5         ��Name$ txtNameControl��5_       $ ��Tên vị trí việc làm��68   ���	#B2000000$
��Bold"�5`   ;   $��10 0 0 0q�5a   $   $��Center=�5b   $   5c      � 5e      -	   5        $ 
controlAdd��5e   *   $��	10 0 10 0q�6   $��2��6>   5g      5h      5i      5j      5k      