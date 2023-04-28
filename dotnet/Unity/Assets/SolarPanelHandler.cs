using Grpc.Core;
using GrpcClients;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using Utils;
using static GrpcBase.TibberMessages.Types;

public class SolarPanelHandler : Singleton<SolarPanelHandler> 
{
    private Collection<SolarPanel> _solarPanels = new();

    [SerializeField] private int infoFetchFrequencyInSeconds = 5;
    [SerializeField] private bool shouldFetch = true;

    private GrpcBase.SolarPanel.SolarPanelClient _client = Clients.Instance.SolarPanel;

    public async void Add(SolarPanel panel)
    {
        _solarPanels.Add(panel);
        await GetInfo();
    }

    private async Task<GrpcBase.SolarPanelMessages.Types.PanelInfoResponse[]> GetInfo()
    {
        var call = _client.GetSolarPanelInfo();
        var panelInfos = _solarPanels.Select(async panel =>
        {
            var (width, height) = panel.GetWidthAndHeight();
            var (tilt, azimuth) = panel.GetTiltAndAzimuth();
            await call.RequestStream.WriteAsync(new()
            {
                PanelName = "SPR",
                PanelWidth = width,
                PanelHeight = height,
                Tilt = tilt,
                Azimuth = azimuth,
                Datetime = new() { Seconds = TimeManager.Instance.Time.Second }
            });

            await call.ResponseStream.MoveNext();
            GrpcBase.SolarPanelMessages.Types.PanelInfoResponse response = call.ResponseStream.Current;
            return response;
            //Debug.Log($"Received response: {response}");
        });
        var results = await Task.WhenAll(panelInfos);
        Debug.Log(results);
        return results;
    }



}
