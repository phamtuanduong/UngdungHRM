   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UngdungHRM.NewControlsUngdungHRM.NewControls  5      0    *UngdungHRM.NewControls.thongtincoquan_item   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:UngdungHRM.NewControls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $��0 10 0 0q�6   $��1��6     � ColumnDefinitions  5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   
�������._�5      �� .+�5      �� -   5         #  MaterialDesignFlatLightBgButton#��[  5      ���	#FF94A4A8
������ 
�������+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5   !   .��6O   Thông tin chung5      �� 5      -   5        #��[  5      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�5   !   $	��180��5    !   $ 15��5"   !   .��6O   Địa điểm cơ quan5$      �� 5&      -   5        #��[  5&      ���	#FF94A4A8
������ 
�������$��0 10 0 0q�5*   !   $	��180��5+   !   $ 15��5-   !   .��6O   Tổ chức5/      50       J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B     MaterialDesignShadow   Color# [ 6R   	   Opacity$		 .42Q�6�   
   RenderingBias$
 Performance=�6�   55      )  #MaterialDesignThemes.Wpf.DialogHost  57   
   -   5          Name$ 
dialogHost��58   %   $��1��57   %   $��10 0 0 0q�65      DialogContent 59      � 5:      -   5         �Name$ dialogHostControl��5:      .��5<      �  � RowDefinitions 5=      �� 5>      $��30 �6$   �� 5?      .+�5B      �� $ 10��6   $ 10q�6+   
�������$��2��5C       5D        5E      $ 5Q�6+   $ 1Q�6:   $	 270Q�6J   # [ 6Z   $		 .42Q�6�   $
 Performance=�6�   5G      �� 5I      ���#EFEFEF$ 	10 10 0 0��5J      ._�5K      �� -   5         ��Name$ txtNameControl��5K       $ ��Tên vị trí việc làm��68   ���	#B2000000$
��Bold"�5L   ;   $��10 0 0 0q�5M   $   $��Center=�5N   $   5O      � 5Q      -   5        $ 
controlAdd��5Q   *   $��	10 0 10 0q�6   $��2��6>   5S      5T      5U      5V      5W      