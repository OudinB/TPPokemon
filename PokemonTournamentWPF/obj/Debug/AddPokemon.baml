   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   H DEntitiesLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:EntitiesLayer;assembly=EntitiesLayerEntitiesLayer 5   	    PokemonTournamentWPF%   PokemonTournamentWPF.AddPokemon   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   Dlocal2clr-namespace:EntitiesLayer;assembly=EntitiesLayer     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Ajouter un Pokémon��5
   	   $��280.415��6$   $	��300��65    � 	Resources 5         dataFromEnum S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName��%}   &	        S� 5   
   $ 	GetValues��62   "  5   !    5      M� 5      $ local:ETypeElement��6   5      5      .��5      � $��0,0,0,61q�6   .+�5   
   �� -   5         ��Name$ titre��5      $��Ajouter un pokémon��6   $��Center=�6<   $
��Left=�6`   $	��Top=�6{   $��Cooper Black)�6�   $��14(�6�   $	��292��6�   �� 5   
   -   5         ��Name$ Retour��5      $��Retour��6!   $
��Left=�62   $��207,156,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        	 ��Name$		 tb1��5      $
��Left=�6!   $��	10,31,0,0q�6<   $
��Wrap=�6O   $��Nom :��6c   $	��Top=�6p   $��Cooper Black)�6�   $��13(�6�   $��19��6�   $��56��6�   �� 5   
   -   5        
 ��Name$	
 Nom��5      $
��Left=�6   $��23��6:   $��	10,55,0,0q�6F    �� TextWrapping$
 Wrap=�6Y   $	��nom��6m   $	��Top=�6x   $	��272��6�   $��Italic$�6�   �� 5   
   -   5        $		 tb2��5      $
��Left=�6!   $��	10,83,0,0q�6<   $
��Wrap=�6O   $��Type :��6c   $	��Top=�6q   $��Cooper Black)�6�   $��13(�6�   $��19��6�   $��56��6�   �� 5   
   -   5         ��Name$
 Type��5      $
��Left=�6!   $��
10,107,0,0q�6<   $	��Top=�6P   $	��173��6h   ��6t   ��  �� Source# [  �� 5   
   -   5        $ Valider��5      $��Valider��6"   $
��Left=�64   $��
10,156,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5        $	 avertissement��5      $
��Left=�6+   $��
10,134,0,0q�6F   $
��Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��262��6�   $��Cooper Black)�6�   $��17��6�   ���	#FFFD00006�   5      5       