   M S B A M L   `   `   `  ����M  IBootcampManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BootcampManagementBootcampManagement  5   	   "    BootcampManagement.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BootcampManagement     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  Bootcamp Management��5	   	   $	��750��6%   $
��1200��62    � 
ResizeMode$ NoResize=�6?    � WindowStyle$
 None=�6U    � WindowStartupLocation$ CenterScreen=�6h   .��5      � .+�5   
   � $	��Top=�6   $��50��6'   $	��900��63   $��Right=�6?   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ Account_Btn��5      ���#878787 � ToolTip$ Account��6p   ��6.   Z� ��6D   Z� .��5      �� $ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ ProfileSession��5   $   $��Your Profile��6<   $
��Left=�6P   $��
-10,0,15,0q�6k   $��Yu Gothic UI Light)�6   6�   '  !MaterialDesignThemes.Wpf.PackIcon  5      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ AccountCircle=�62   $��30��6G   $��30��6R   $��-10 -5q�6^   $��Right=�6n   5      5      �� 5      -   5        $ Mail_Btn��5      ���#878787$��Center=�6m   $
 Mail��6�   ��6+   Z� ��6A   Z� .��5        $
 Mail=�6.   $��30��6:   $��30��6E   $	��-10q�6Q   5      �� 5      -   5        $ Setting_Btn��5      ���#878787$��Center=�6p   $ Setting��6�   {�.  ��6.   Z� ��6D   Z� .��5        $
 Gear=�6.   $��30��6:   $��30��6E   $	��-10q�6Q   
������ 6^   5      �� 5      -   5        $ 	Close_Btn��5      ���#878787$��Center=�6n   $ Close Application��6�   ��6,   Z� ��6B   Z� .��5        $ Close=�6.   $��30��6;   $��30��6F   $	��-10q�6R   5      5      5      � 5   
   $	��750��6   $	��300��6   $
��Left=�6(   ���#1F2626.+�5       �� -   5        	 ��Name$	 Menu_ListView��5       
�������$��Yu Gothic UI Light)�6F   $��Disabled=�6�   .@�5!      �� $	��100��6   .��5"      �� $ 
Horizontal=�6!   .+�5#      �� -   5        
 ��Name$3
 -___BootcampManagement_component_metrodata_png��5#       $7��1/BootcampManagement;component/Image/metrodata.png��6W   $
��Fill=�6�   $��82��6�   $	��244��6�   $
��20 0q�6�   5$      5%      �� 5&      $��50��6   .��5'      �� $ 
Horizontal=�6!   .+�5(        $ Museum=�62   $��30��6@   $��30��6K   $
��30 0q�6W   $��Center=�6e   �� 5)      $��	Dashboard��6$   $��Center=�65   $��20(�6P   5*      5+      �� 5,      -	   5         ��Name$ ListViewItemTwo��5,   +   $��50��6   .��5-      �� $ 
Horizontal=�6!   .+�5.        -
   5          Name$ ListTwo_Icon��5.   I   $ FileDocumentBox=�62   $��30��6_   $��30��6j   $
��30 0q�6v   $��Center=�6�   �� 5/      -   5        $ ListTwo_Txt��5/   $   $��Build Your CV��69   $��Center=�6N   $��20(�6i   50      51      �� 52      -   5        $ ListViewItemThree��52   +   $��50��6   .��53      �� $ 
Horizontal=�6!   .+�54        -   5        $ ListThree_Icon��54   G   $ ClipboardUser=�62   $��30��6_   $��30��6j   $
��30 0q�6v   $��Center=�6�   �� 55      -   5        $ ListThree_Txt��55   $   $��Manage Access Card��6;   $��Center=�6U   $��20(�6p   56      57      �� 58      -   5        $ ListViewItemFour��58   +   $��50��6   .��59      �� $ 
Horizontal=�6!   .+�5:        -   5        $ ListFour_Icon��5:   G   $ LaptopWindows=�62   $��30��6^   $��30��6i   $
��30 0q�6u   $��Center=�6�   �� 5;      -   5        $ ListFour_Txt��5;   $   $��Manage Lesson��6:   $��Center=�6O   $��20(�6j   5<      5=      �� 5>      -   5        $ ListViewItemFive��5>      .��5?      9� 
�������
������ $��20(�6K   $	��300��6Y   $��	-8,-6,0,0q�6e   ��5@      �� 5A       �� Bullet 5B   "     5C   &   -   5        $ ListFive_Icon��5C   U   $ TableOfContents=�6>   $��30��6l   $��30��6w   $
��14 0q�6�   $��Center=�6�   ._�5E   "   �� -   5        $ ListFive_Txt��5E   ,   $��Build Your CV��6B   $��Center=�6W   $��20(�6r   $��43.6,0,-27.2,0q�6�   5F      .��5H      �� $ Vertical=�6%   
�������$��8,0,0,0q�6Y   $	��285��6j   .+�5I      �� -   5         ��Name$ DailyScore_LView��5I   )   $ 
Horizontal=�6C   $��40��6\    � Cursor$
 Hand��6h   .+�5J   "     $ 	EventTick=�6:   $��30��6K   $��30��6V   $��	45,0,30,0q�6b   $��Center=�6u   �� 5K   "   -   5        $ DailyScore_Txt��5K   ,   $��Daily Score��6D   $��Center=�6W   5L      �� 5M      -   5        $ WeeklyScore_LView��5M   )   $ 
Horizontal=�6D   $��40��6]   $
 Hand��6i   .+�5N   "     $ 	EventStar=�6:   $��30��6K   $��30��6V   $��	45,0,30,0q�6b   $��Center=�6u   �� 5O   "   -   5        $ WeeklyScore_Txt��5O   ,   $��Weekly Score��6E   $��Center=�6Y   5P      5Q      5R      5S      �� 5T      -   5        $ ListViewItemSix��5T   +   $��50��6   .��5U      �� $ 
Horizontal=�6!   .+�5V        -   5        $ ListSix_Icon��5V   H   $ OfficeBuilding=�62   $��30��6^   $��30��6i   $
��30 0q�6u   $��Center=�6�   �� 5W      -   5        $ ListSix_Txt��5W   $   $��Manage Site��69   $��Center=�6L   $��20(�6g   5X      5Y      5Z      5[      � 5\   
   .+�5]      � -   5         �Name$ 	Main_Grid��5]      $	��Top=�6&   $	��850��6>   $	��700��6J   $��
300,50,0,0q�6W   6m   5^      � 5_   
   .+�5`      �� -   5        $ FAQ_Btn��5`      ���#878787$��Center=�6h   $	 FAQ��6�   $��10,708,1148,10.4q�6�   ��6&   Z� ��6<   Z� .��5a        $ Information=�6*   $��30��6=   $��30��6H   $	��-10q�6T   
�������6a   5b      5c      5d      5e      