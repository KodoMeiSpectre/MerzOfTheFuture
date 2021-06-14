using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class RoomSync : RealtimeComponent<RoomSyncModel>
{
    public MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = transform.GetComponent<MeshRenderer>();
    }
    protected override void OnRealtimeModelReplaced(RoomSyncModel previousModel, RoomSyncModel currentModel)
    {
        if (previousModel != null)
        {
            previousModel.isVisibleDidChange -= IsVisibleDidChange;
        }

        if (currentModel != null)
        {
            if (currentModel.isFreshModel)
                currentModel.isVisible = _meshRenderer.enabled;

            UpdateMeshIsVisible();

            currentModel.isVisibleDidChange += IsVisibleDidChange;
        }
    }

    private void IsVisibleDidChange(RoomSyncModel model, bool value)
    {
        UpdateMeshIsVisible();
    }

    private void UpdateMeshIsVisible()
    {
        _meshRenderer.enabled = model.isVisible;
    }

    public void SetState(bool boolean)
    {
        model.isVisible = boolean;
    }
}

