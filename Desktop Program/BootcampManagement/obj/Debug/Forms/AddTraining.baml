   M S B A M L   `   `   `  ����M  IBootcampManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BootcampManagement.FormsBootcampManagement.Forms  5   	   *    $BootcampManagement.Forms.AddTraining   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:BootcampManagement.Forms     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Add Training��5	   	   $	��400��6   $	��600��6+    � 
ResizeMode$ NoResize=�67    � WindowStyle$
 None=�6M    � WindowStartupLocation$ Manual=�6`    � Left$	 620��6   
 � Top$	 230��6�   .��5
      � -   5        .+�5   
   �� ���#00003D.+�5      �� $
��Wrap=�6   $��0,10,0,0q�6,   $��Add Training��6>   $��Center=�6R   
�������$��25(�6�   $��Yu Gothic UI Bold)�6�   5      �� 5   
   -   5         ��Name$ 	Close_Btn��5      
�������$��Center=�6d    � ToolTip$ Close Application��6�   $��560,0,0,364q�6�   ��6$   Z� ��6:   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6&   $��30��63   $��30��6>   $��-13 -5q�6J   5      �� 5   
   	 �� Orientation$	 
Horizontal=�6   $��	40,70,0,0q�6.   .+�5      �� $
��Wrap=�6   $��Training Name :��6,   
�������$��12(�6V   $��Yu Gothic UI Light)�6d   $��	0,0,255,0q�6�   �� 5      $
��Wrap=�6   $��	Periode :��6,   
�������$��12(�6P   $��Yu Gothic UI Light)�6^   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
  ��6~   5      �� 5   
   $	 
Horizontal=�6   $��	40,90,0,0q�6.   .+�5      �� -   5         ��Name$ TrainingName_Tbox��5      $
��Left=�61   $��23��6L   $��0,5,0,0q�6X    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��305��6�   
�������
�������$��Yu Gothic UI Light)�6�   �� 5      -   5        $ PeriodeStart_Tbox��5      $
��Left=�61   $��23��6L   $��30,5,0,0q�6X   $
 Wrap=�6j   $	��Top=�6~   $��75��6�   
�������
�������$��Yu Gothic UI Light)�6�   �� 5      $
��Wrap=�6   $��-��6,   
�������$��45(�6H   $��Yu Gothic UI Light)�6V   $��	9,-20,9,0q�6v   $��45��6�   $	��Top=�6�   �� 5      -   5        $ PeriodeEnd_Tbox��5      $
��Left=�6/   $��23��6J   $��0,5,0,0q�6V   $
 Wrap=�6g   $	��Top=�6{   $��75��6�   
�������
�������$��Yu Gothic UI Light)�6�   5      �� 5   
   $	 
Horizontal=�6   $��353,140,34,227q�6.   .+�5      �� -   5        $ 
Cancel_Btn��5      $��Cancel��6)   $	��Top=�6:   $
��Left=�6R   $��90��6m   $��30��6x   ���#FFCB48���#FFCB48$��Yu Gothic UI Light)�6�   $��	10,0,25,0q�6�   �� 5      -   5        $ Add_Btn��5      $
��Save��6&   $	��Top=�65   $
��Left=�6M   $��85��6h   $��30��6s   $��Yu Gothic UI Light)�6   5      �� 5   
   $��	0,190,0,0q�6   .+�5       &   System.Windows.Controls.DataGrid  -   5          Name$ AddTraining_DataGrid��5       
�������$��1q�6M   ���#00003D$��Center=�6v   $	��Top=�6�   $	��180��6�   $	��522��6�      AutoGenerateColumns .  $��	38,0,40,0q�6�      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ No��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5#      $ Training Name��6)   $ * 6Y    6@   �� *Name+6Y      ColumnHeaderStyle 5%      �� 5&       �� 
TargetType=	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6   .�5'      ��  �� Property � �� �� Value$ Center=�6G   �� 5(       � �� �#00003D67   �� 5)       � ��$ 30��63   �� 5*       � ��
 �����67   �� 5+       � ��
 �����68   �� 5,       � ��$ 1q�6<   5-      5/      50      51      52      