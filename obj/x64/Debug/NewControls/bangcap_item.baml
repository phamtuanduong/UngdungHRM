   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UngdungHRM.NewControlsUngdungHRM.NewControls  5      )    #UngdungHRM.NewControls.bangcap_item   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:UngdungHRM.NewControls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $��0 10 0 0q�6   $��1��6     � ColumnDefinitions  5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   
�������._�5      �� .+�5      �� -   5         #  MaterialDesignFlatLightBgButton#��[  5      ���	#FF94A4A8
������ 
�������+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5   !   .��6O   
Kỹ năng5      �� 5      -   5        #��[  5      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�5   !   $	��180��5    !   $ 15��5"   !   .��6O   Giáo dục5$      �� 5&      -   5        #��[  5&      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�5*   !   $ 15��5,   !   .��6O   Chứng chỉ5.      �� 50      -   5        #��[  50      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�54   !   $ 15��56   !   .��6O   Ngôn ngữ58      5:       J� Effect 5<      3  -System.Windows.Media.Effects.DropShadowEffect  5=         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B     MaterialDesignShadow   Color# [ 6R   	   Opacity$		 .42Q�6�   
   RenderingBias$
 Performance=�6�   5?      )  #MaterialDesignThemes.Wpf.DialogHost  5A   
   -   5          Name$ 
dialogHost��5B   %   $��1��5A   %   $��10 0 0 0q�65      DialogContent 5C      � 5D      -   5         �Name$ dialogHostControl��5D      .��5F      �  � RowDefinitions 5G      �� 5H      $��30 �6$   �� 5I      .+�5L      �� $ 10��6   $ 10q�6+   
�������$��2��5M       5N        5O      $ 5Q�6+   $ 1Q�6:   $	 270Q�6J   # [ 6Z   $		 .42Q�6�   $
 Performance=�6�   5Q      �� 5S      ���#EFEFEF$ 	10 10 0 0��5T      ._�5U      �� -   5         ��Name$ txtNameControl��5U       $��
Kỹ năng��68   ���	#B2000000$
��Bold"�5V   ;   $��10 0 0 0q�5W   $   $��Center=�5X   $   5Y      � 5[      -   5        $ 
controlAdd��5[   *   $��	10 0 10 0q�6   $��2��6>   5]      5^      5_      5`      5a      