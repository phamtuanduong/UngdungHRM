   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:UngdungHRM.ControlsItemUngdungHRM.ControlsItem  5      5    /UngdungHRM.ControlsItem.qualifications_licenses   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:UngdungHRM.ControlsItem     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      .��5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffects  5   
   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�6.     5      $ SlideInFromRight=�6.   .��5   
   �  � RowDefinitions 5      �� 5      $��45 �6    �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         #  MaterialDesignFlatLightBgButton#��[  5      
��� � �
�������$��0 0 10 0q�5      $	��120��5      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5      .��5      �� $ 
Horizontal=�6!   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PencilPlus=�62   $��Center=�6D   �� 5       $��Thêm mới��6$   $��5 0 0 0q�64   5!      5"      �� 5$      -   5        #��[  5$      ���	#FFD63512
�������$��0 0 10 0q�5'      $	��120��5(      
������ $ 15��5+      .��5,      �� $ 
Horizontal=�6!   .+�5-        $ Close=�62   $��Center=�6?   �� 5.      $
��Xóa��6$   $��5 0 0 0q�6/   5/      50      51      �� 52      $��Bottom=�6   ���	#FF63636363   &   System.Windows.Controls.DataGrid  53      -   5          Name$
 data��53      $��1��6%      AutoGenerateColumns .     HeadersVisibility$	 All=�55      
������ 	   CanUserAddRows	 .  $��Stretch=�59      $��Stretch=�5:      
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 5;      ��57      �� *list+   Columns 5=      4  .System.Windows.Controls.DataGridCheckBoxColumn  5>       - )MaterialDesignDataGridCheckBoxColumnStyle1	  +System.Windows.Controls.DataGridBoundColumn 	  ElementStyle# [ 5?   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle 	  EditingElementStyle# [ 5@   -   ,
  &System.Windows.Controls.DataGridColumn 
  Width$ 50 5A   -    	  Binding 5>   -   �� *
IsSelect+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 
  Header 5B      �� 5C      
������ ._�5D   "   �� -   5         ��Name$ checkAll��5D   +    d� 	IsChecked 6>   �� *IsAllSelect+5E   %   5F       
  HeaderStyle 5H      �� 5I       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$    & "MaterialDesignDataGridColumnHeader �� BasedOn# [ 5J   $   .�5K   "   ��  �� Property � �� �� Value$ Center=�6O   5L      5N      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5P      $
 Tên��5R       
  
IsReadOnly .  5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5T       5Q      �� *Name+ 5U      �� 5V      "  5W      # [ 5X      .�5Y   "   ��  � ��$
 Left=�5[      �� 5\   "    � �� 5^   &   �� 5_   *   .R�5`   .   �� $
��Wrap=�5a       �� TextAlignment$
 Left=�5c      ��5b      �� 5c      5d   +   5f   #   5g       5i      �� 5j      " ��5k       ) %MaterialDesignDataGridTextColumnStyle# [ 5l      .�5m   "   ��  � ��$
 Left=�5o      5p      5r      5v      5w      5x      5y      