using System.Collections.Generic;

public class WeaponManager
{
    private GameManager gameManager;

    private List<Gun> weapons;
    private Gun activeWeapon;

    public WeaponManager(GameManager _gameManager)
    {
        gameManager = _gameManager;
        // add listeners
        EventSystem.AddListener(EventType.INPUT_NEXT_WEP, NextWeapon);
        EventSystem.AddListener(EventType.INPUT_PREV_WEP, PrevWeapon);
    }

    ~WeaponManager()
    {
        // remove listeners
        EventSystem.RemoveListener(EventType.INPUT_NEXT_WEP, NextWeapon);
        EventSystem.RemoveListener(EventType.INPUT_PREV_WEP, PrevWeapon);
    }

    private void PickupWeapon()
    {
        // add new weapon to list
    }

    private void DropWeapon()
    {
        // disable active weapon and remove it from list, make previous weapon active
    }

    private void NextWeapon()
    {
        // disable active weapon and make next weapon in the list active
    }

    private void PrevWeapon()
    {
        // disable active weapon and make previous weapon in the list active
    }
}